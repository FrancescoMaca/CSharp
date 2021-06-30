using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CPU_Scheduler
{
    /*
     * This class has all the necessary methods to simulate the CPU
     * scheduling algorithms.
     * It also has a draw function to display it to the current graphics.
     */
    public static class AlgorithmManager
    {
        /*
         * Flags for the scheduling condition.
         */
        public static bool HasContextSwitch { get; set; }
        public static bool HasModeSwitch { get; set; }

        /*
         * Emunarator to rapresent which type of algorithm to use.
         */
        public enum Type
        {
            Fcfs, Sjf, Srtf, RoundRobin, Priority, None
        }

        private static PaintEventHandler _paintCallback;

        /*
         * Draws the scheduling block to the give graphic panel.
         */
        public static void Draw(ScheduleSummary summary, Panel graphics)
        {
            // Gathers all the child panels of the graph
            List<Control> processRows = graphics.GetAll(typeof(Panel)).ToList();

            graphics.Paint -= _paintCallback;

            _paintCallback = new PaintEventHandler((object sender, PaintEventArgs e) => {

                e.Graphics.Clear(Color.LightGray);

                // Gets the current timeline's panel size
                int rowLength = processRows[0].Width - Constants.GraphRightOffset;

                // Based on the total size of the row it calculates the size in pixel of a unit
                int unitSize = rowLength / summary.TotalTime;

                // Loops through all the sorted executions blocks
                for(int i = 0; i < summary.ExecutionBlocks.Length; i++)
                {
                    // Searches the process timeline panel
                    Panel pnRowGraphic = (Panel)processRows.Find(p =>
                    {
                        if (p.Name == "pnTimeline" + summary.ExecutionBlocks[i].Owner.ID)
                        {
                            return true;
                        }

                        return false;
                    });

                    // Calculates the x coordinate of the block
                    int x = summary.ExecutionBlocks[i].Time.Start * unitSize;

                    // Checks if the mode the process are running is different, if it is, then a mode-switch will be
                    // counted in the timeline
                    if (HasModeSwitch && i != 0 && (summary.ExecutionBlocks[i].Owner.IsKernel != summary.ExecutionBlocks[i - 1].Owner.IsKernel))
                    {
                        var control = new Panel()
                        {
                            Location = new Point(x + Constants.GraphLabelWidth - (Constants.GraphModeSwitchTime * unitSize), 0),
                            Size = new Size(Constants.GraphModeSwitchTime * unitSize, graphics.Height),
                            BackColor = Color.FromArgb(255, Color.FromArgb(Constants.GraphModeSwitchColor)),
                            Name = $"pnModeSwitch{summary.ExecutionBlocks[i].Owner.ID}"
                        };

                        graphics.Controls.Add(control);
                        control.BringToFront();
                    }

                    // Calculates the current block width
                    int blockWidth = unitSize * summary.ExecutionBlocks[i].Time.Duration;

                    // subtracting 1 so the rectangle doesn't overlap the panel's border
                    int blockHeight = pnRowGraphic.Height - 1;

                    // Creates the new rectangle on the panel
                    Rectangle bounds = new Rectangle(x, 0, blockWidth, blockHeight);

                    // Fills the rectangle with the process' color
                    pnRowGraphic.CreateGraphics().FillRectangle(new SolidBrush(summary.ExecutionBlocks[i].Owner.Color), bounds);

                    // If the rectangle starts at 0 
                    ControlPaint.DrawBorder(pnRowGraphic.CreateGraphics(), bounds,
                        Color.Black, System.Convert.ToInt32(x != 0), ButtonBorderStyle.Solid,
                        Color.Black, 0, ButtonBorderStyle.Solid,
                        Color.Black, 1, ButtonBorderStyle.Solid,
                        Color.Black, 0, ButtonBorderStyle.Solid);

                    // Adds the bound value as text
                    TextRenderer.DrawText(pnRowGraphic.CreateGraphics(),
                        summary.ExecutionBlocks[i].Time.Start.ToString(),
                        new Font(FontFamily.GenericSansSerif, 6f),
                        new Point(x, 0),
                        summary.ExecutionBlocks[i].Owner.Color.GetBrightness() < 0.5 ? Color.White : Color.Black);

                    // Updating the x coordinate with the process execution block length
                    x += blockWidth;

                    TextRenderer.DrawText(pnRowGraphic.CreateGraphics(),
                        summary.ExecutionBlocks[i].Time.End.ToString(),
                        new Font(FontFamily.GenericSansSerif, 6f),
                        new Point(x - 25, 0),
                        summary.ExecutionBlocks[i].Owner.Color.GetBrightness() < 0.5 ? Color.White : Color.Black);

                    if (HasContextSwitch)
                    {
                        var control = new Panel()
                        {
                            Location = new Point(x + Constants.GraphLabelWidth, 0),
                            Size = new Size(Constants.GraphContextSwitchTime * unitSize, graphics.Height),
                            BackColor = Color.FromArgb(255, Color.FromArgb(Constants.GraphContextSwitchColor)),
                            Name = $"pnContextSwitch{summary.ExecutionBlocks[i].Owner.ID}"
                        };

                        x += Constants.GraphContextSwitchTime * unitSize;
                        graphics.Controls.Add(control);
                        control.BringToFront();
                    }
                }
            });

            graphics.Paint += _paintCallback;

            // Redraws the control
            graphics.Invalidate();
        }

        public static ScheduleSummary Fcfs(Process[] processes)
        {
            // Ordering processes for the FCFS
            processes = processes.OrderBy(proc => proc.Arrival).ToArray();

            // Creating the list for the time slices
            List<ExecutionBlock> burstOrder = new List<ExecutionBlock>();

            int currentTime = 0;

            for(int i = 0; i < processes.Length; i++)
            {
                // If there is a mode switch it adds it to the time before the process
                // burst is created
                if (HasModeSwitch && i != 0 && processes[i - 1].IsKernel != processes[i].IsKernel)
                {
                    currentTime += Constants.GraphModeSwitchTime;
                }

                // if the process arrives after the last process execution it sets the current time to the new process
                // arrival time
                if (currentTime < processes[i].Arrival)
                {
                    currentTime = processes[i].Arrival;
                }

                //Create the execution block
                ExecutionBlock burst = CreateBurst(processes[i], currentTime);

                // Add the execution block to the list
                burstOrder.Add(burst);

                // increment time
                currentTime += processes[i].Duration;
                
                if (HasContextSwitch)
                {
                    currentTime += Constants.GraphContextSwitchTime;
                }
            }

            return new ScheduleSummary(burstOrder.ToArray());
        }

        public static ScheduleSummary Sjf(Process[] processes)
        {
            // Ordering the process by their arrival time
            List<Process> newProcesses = processes.OrderBy(process => process.Arrival).ToList();

            // Creating the list for the time slices
            List<ExecutionBlock> burstOrder = new List<ExecutionBlock>();

            int currentTime = 0;

            Process oldProcess = null;

            while (newProcesses.Count > 0)
            {
                Process nextProcess = newProcesses[0];

                // Loops thorugh all the process and searches the best process to be executed
                foreach (var proc in newProcesses)
                {
                    // if one of these process has a duration that is less than the current
                    // process, then we select that process (following SJF scheduling)
                    if (nextProcess.Duration > proc.Duration && proc.Arrival <= currentTime)
                    {
                        nextProcess = proc;
                    }
                }

                if (currentTime < nextProcess.Arrival)
                {
                    currentTime = nextProcess.Arrival;
                }

                if (HasModeSwitch && oldProcess != null && oldProcess.IsKernel != nextProcess.IsKernel)
                {
                    currentTime += Constants.GraphModeSwitchTime;
                }

                //Create the execution block
                ExecutionBlock burst = CreateBurst(nextProcess, currentTime);

                // Add the execution block to the list
                burstOrder.Add(burst);

                // updates current time
                currentTime += nextProcess.Duration;

                if (HasContextSwitch)
                {
                    currentTime += Constants.GraphContextSwitchTime;
                }

                // Reassigns the oldProcess and deletes the process from the list
                oldProcess = nextProcess;
                newProcesses.Remove(nextProcess);
            }

            return new ScheduleSummary(burstOrder.ToArray());
        }

        public static ScheduleSummary Srtf(Process[] processes)
        {
            MessageBox.Show("This algorithm has not been implemented yet!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return new ScheduleSummary();
        }

        public static ScheduleSummary RoundRobin(Process[] processes, int sliceTime)
        {
            MessageBox.Show("This algorithm has not been implemented yet!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return new ScheduleSummary();
        }

        public static ScheduleSummary Priority(Process[] processes)
        {
            List<Process> newProcesses = processes.OrderBy(proc => proc.Arrival).ToList();

            // Creating the list for the time slices
            List<ExecutionBlock> burstOrder = new List<ExecutionBlock>();

            int currentTime = 0;

            Process oldProcess = null;

            while (newProcesses.Count > 0)
            {
                Process nextProcess = newProcesses[0];

                foreach(var proc in newProcesses)
                {
                    if (proc.Arrival <= currentTime && proc.Priority > nextProcess.Priority)
                    {
                        nextProcess = proc;
                    }
                }

                if (currentTime < nextProcess.Arrival)
                {
                    currentTime = nextProcess.Arrival;
                }

                if (HasModeSwitch && oldProcess != null && oldProcess.IsKernel != nextProcess.IsKernel)
                {
                    currentTime += Constants.GraphModeSwitchTime;
                }

                //Create the execution block
                ExecutionBlock burst = CreateBurst(nextProcess, currentTime);

                // Add the execution block to the list
                burstOrder.Add(burst);

                // updates current time
                currentTime += nextProcess.Duration;

                if (HasContextSwitch)
                {
                    currentTime += Constants.GraphContextSwitchTime;
                }

                oldProcess = nextProcess;
                newProcesses.Remove(nextProcess);
            }

            return new ScheduleSummary(burstOrder.ToArray());
        }
        
        private static ExecutionBlock CreateBurst(Process process, int start)
        {
            
            return new ExecutionBlock(process, start, start + process.Duration);
        }

        //private static ExecutionBlock CreateBurst(Process process, int start, int duration)
        //{
        //    return new ExecutionBlock(process, start, start + duration);
        //}
    }

    /*
     * This class contains all the information about the scheduling.
     * In particular details about the CPU usage and scheduling performance.
     */
    public class ScheduleSummary
    {
        /*
         * Needs to:
         * - calculate the CPU usage
         * - calculate the throughput
         * - calculate the total waiting time
         * - calculate the total schedule time
         * - contain the entire sequence of cpu bursts
         */

        //public static ScheduleSummary empty = new ScheduleSummary();

        public ExecutionBlock[] ExecutionBlocks { get; set; }

        public int WaitingTime { get; private set; }
        public int BurstTime { get; private set; }
        public int ProcessNumber { get; private set; }
        public int TotalTime { get; private set; }

        public float Throughput { get; private set; }
        public float CpuUsage { get; private set; }

        public ScheduleSummary()
        {
            ExecutionBlocks = null;

            WaitingTime = 0;
            //TurnaroundTime = -1;
            Throughput = 0;
            BurstTime = 0;
            ProcessNumber = 0;
            TotalTime = 0;
            CpuUsage = 0;
        }

        public ScheduleSummary(ExecutionBlock[] blocks)
        {
            ExecutionBlocks = blocks;

            ProcessNumber = blocks.Distinct().Count();
            TotalTime = GetTotalTime();
            BurstTime = GetBurstTime();
            WaitingTime = GetWaitingTime();
            Throughput = GetThroughput();
            CpuUsage = GetCpuUsage();
        }

        /* Returns the total amount of time of the scheduling. */
        private int GetTotalTime()
        {
            return ExecutionBlocks.Max(block => block.Time.End);
        }

        /* Returns the amount of process completed per time unit. */
        private float GetThroughput()
        {
            return ProcessNumber / (float)TotalTime;
        }

        /* Returns the total amount of time in which the CPU has been busy. */
        private int GetBurstTime()
        {
            return ExecutionBlocks.Sum(block => block.Owner.Duration);
        }

        /* Returns the total amount of waiting time. */
        private int GetWaitingTime()
        {
            return TotalTime - BurstTime;
        }

        /* Returns the CPU usage in percentage. */
        private float GetCpuUsage()
        {
            return BurstTime * 100 / (float)TotalTime;
        }

        public override string ToString()
        {
            return $"Process number: {ProcessNumber}\n" +
                            $"TotalTime: {TotalTime}ms\n" +
                            $"Waiting Time: {WaitingTime}ms\n" +
                            $"Throughput Time: {string.Format("{0:0.00}", Throughput)}p/ms\n" +
                            $"Burst Time: {BurstTime}ms\n" +
                            $"CPU Usage: {CpuUsage}%";
        }
    }
}