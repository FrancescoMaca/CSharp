using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace CPU_Scheduler
{
    /*
     * Main UI window class
     */
    public partial class MainWindow : Form
    {
        // The processes in the listview
        private readonly List<Process> _activeProcesses;

        private AlgorithmManager.Type _currentAlgorithm = AlgorithmManager.Type.None;

        public static bool ConfirmOnExit = false;

        // Default save path of the configurations
        public static string SavePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public MainWindow()
        {
            InitializeComponent();
            
            // Initializing the list
            _activeProcesses = new List<Process>();
        }
        
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Adding test processes
            Random rand = new Random();
            AddProcess(new Process(Process.GenerateNewID(), rand.Next(0, 10), rand.Next(5, 20), "Test Process 1"));
            AddProcess(new Process(Process.GenerateNewID(), rand.Next(0, 10), rand.Next(5, 20), "Test Process 2"));
            AddProcess(new Process(Process.GenerateNewID(), rand.Next(0, 10), rand.Next(5, 20), "Test Process 3"));

            // Initializing list view
            lvProcesses.FullRowSelect = true;

            // Initializing graphic panel
            pnGraphic.Height = Constants.GraphProcessView * Constants.GraphRowHeight;
            pnGraphic.BackColor = Color.FromArgb(255, Color.FromArgb(Constants.GraphDefaultColor));

            // hiding the scrollbar
            pnGraphic.AutoScroll = false;
            pnGraphic.VerticalScroll.Enabled = false;
            pnGraphic.VerticalScroll.Visible = false;
            pnGraphic.VerticalScroll.Maximum = 0;
            pnGraphic.AutoScroll = true;

            // Setting the first item of the dropdown
            cbAlgorithm.SelectedIndex = 0;

            // Setting up the tool tips
            ttCpuUsage.SetToolTip(lbCpuUsageValue, "0  - 40% : Very bad CPU utilization\n" +
                                                   "41 - 70% : Discrete CPU utilization\n" + 
                                                   "71 - 100% : Very good CPU utilization\n");

            ttTimeSlice.SetToolTip(lbTimeSlice, "This option is ONLY used in round robin algorithm.\n" +
                                                "It specifies how long the CPU burst should be for\n" +
                                                "each process.");

            // Sets the default time slice value (4)
            cbTimeSlice.SelectedIndex = 3;

            // If the application is in development it shows the form
            if (Constants.inDevelopment)
            {
                new WelcomeForm().Show();
            }
        }

        private void AddProcess(Process NewProcess)
        {
            // If you have less than a certain amount of processes the you can add more
            if (_activeProcesses.Count < Constants.MaxProcesses)
            {
                // Adds the process to the list view
                lvProcesses.AddProcess(NewProcess);

                // Adds the process to the list
                _activeProcesses.Add(NewProcess);
            }
            else
            {
                MessageBox.Show($"You cannot add more than {Constants.MaxProcesses} processes at the same time!", "Process limit reached", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RemoveProcess()
        {
            // Remove the process only if there are enough in the list
            if (_activeProcesses.Count > Constants.MinProcesses && lvProcesses.SelectedItems.Count > 0)
            {
                if (lvProcesses.SelectedItems.Count > _activeProcesses.Count - 1)
                {
                    MessageBox.Show($"You cannot have less than {Constants.MinProcesses} processes!", "Process limit reached", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Loops through all the selected processes
                foreach (ListViewItem selectedItem in lvProcesses.SelectedItems)
                {
                    // Removing the selected process from the list
                    _activeProcesses.Remove(_activeProcesses.Find((Proc) => {
                        if (Proc.ID.Equals(selectedItem.SubItems[3].Text))
                        {
                            return true;
                        }

                        return false;
                    }));
                }

                // Removing process from the listview
                lvProcesses.RemoveProcess();

                return;
            }
            else if (_activeProcesses.Count > Constants.MinProcesses)
            {
                // Removing the last process from the list
                _activeProcesses.RemoveAt(_activeProcesses.Count - 1);

                // Removing process from the listview
                lvProcesses.RemoveProcess();

                return;
            }

            MessageBox.Show($"You cannot have less than {Constants.MinProcesses} processes!", "Process limit reached", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btAddProcess_Click(object sender, EventArgs e)
        {
            // Creating a default process
            Process TempProcess = new Process(Process.GenerateNewID(), 10, 10);

            // Adding process
            AddProcess(TempProcess);
        }

        private void btRemoveProcess_Click(object sender, EventArgs e)
        {
            // Removes a project from the listView and from the list
            RemoveProcess();
        }

        private void btEditProcess_Click(object sender, EventArgs e)
        {
            if (lvProcesses.SelectedItems.Count >= 1)
            {
                Process TargetProcess = _activeProcesses.Find((Proc) =>
                {
                    if (Proc.ID.Equals(lvProcesses.SelectedItems[0].SubItems[3].Text))
                    {
                        return true;
                    }

                    return false;
                });

                if (TargetProcess != null)
                {
                    // Displays the dialog
                    new EditProcessForm(TargetProcess).ShowDialog();

                    // Copies the new values
                    lvProcesses.SelectedItems[0].SubItems[0].Text = TargetProcess.Name + (TargetProcess.IsKernel ? $" {Constants.ProcessKernelSign}" : "");
                    lvProcesses.SelectedItems[0].SubItems[1].Text = TargetProcess.Arrival.ToString();
                    lvProcesses.SelectedItems[0].SubItems[2].Text = TargetProcess.Duration.ToString();

                    // Setting listView colors
                    lvProcesses.SelectedItems[0].BackColor = TargetProcess.Color;

                    // Sets the fore color text
                    lvProcesses.SelectedItems[0].ForeColor = TargetProcess.Color.GetBrightness() < 0.5 ? Color.White : Color.Black;

                    // Deselects the modified process
                    lvProcesses.SelectedItems.Clear();
                }
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            // Draws the processes on the graph
            InitializeGraph();

            // Defining the return object for each algorithm
            ScheduleSummary Summary = null;

            // Updates the class flags 
            AlgorithmManager.HasContextSwitch = cbContextSwitch.Checked;
            AlgorithmManager.HasModeSwitch = cbModeSwitch.Checked;

            switch (_currentAlgorithm)
            {
                case AlgorithmManager.Type.Fcfs:
                    Summary = AlgorithmManager.Fcfs(_activeProcesses.ToArray());
                    break;

                case AlgorithmManager.Type.Sjf:
                    Summary = AlgorithmManager.Sjf(_activeProcesses.ToArray());
                    break;

                case AlgorithmManager.Type.Srtf:
                    /*Summary = */AlgorithmManager.Srtf(_activeProcesses.ToArray());
                    break;

                case AlgorithmManager.Type.RoundRobin:
                    /*Summary = */AlgorithmManager.RoundRobin(_activeProcesses.ToArray(), 4);
                    break;

                case AlgorithmManager.Type.Priority:
                    Summary = AlgorithmManager.Priority(_activeProcesses.ToArray());
                    break;
            }

            // If the summary is not null then updates the graph
            if (Summary != null)
            {
                AlgorithmManager.Draw(Summary, pnGraphic);
                UpdateOutput(Summary);
            }
        }

        /* Updates the whole output text, and colors it based on the value*/
        private void UpdateOutput(ScheduleSummary summary)
        {
            lbTotalWaitingTimeValue.Text = summary.WaitingTime.ToString() + " time units";
            lbThroughputValue.Text = string.Format("{0:0.00} process/time unit", summary.Throughput);
            lbTotalTimeValue.Text = summary.TotalTime.ToString() + " time units";
            lbTotalBurstValue.Text = summary.BurstTime.ToString() + " time units";
            lbCpuUsageValue.Text = string.Format("{0:0.00}", summary.CpuUsage) + "%";

            // Based on the value it sets the label's color (probably its better inside the label's
            // paint event)
            if (summary.CpuUsage <= 40.0)
            {
                lbCpuUsageValue.ForeColor = Color.Red;
            }
            else if (summary.CpuUsage > 40.0 && summary.CpuUsage <= 70.0)
            {
                lbCpuUsageValue.ForeColor = Color.Orange;
            }
            else
            {
                lbCpuUsageValue.ForeColor = Color.Green;
            }
        } 

        /* Clears the graph */
        private void btClear_Click(object sender, EventArgs e)
        {
            pnGraphic.Controls.Clear();
            UpdateOutput(new ScheduleSummary());
        }

        private void cbAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Converts the selected item to a algorithm type
            if (Enum.TryParse(System.Text.RegularExpressions.Regex.Replace(cbAlgorithm.SelectedItem.ToString(), @"\s+", ""), true, out AlgorithmManager.Type Type))
            {
                _currentAlgorithm = Type;
            }

            switch (_currentAlgorithm)
            {
                case AlgorithmManager.Type.Fcfs:
                    lbAlgorithmDescriptionValue.Text = "The FCFS (First Come First Served) scheduling algorithm is the easiest and simplest scheduling algorithm. In this type of algorithm, processes which requests the CPU first get the CPU allocation first. This is managed with a FIFO (First in First Out) queue.";
                    break;
                case AlgorithmManager.Type.Sjf:
                    lbAlgorithmDescriptionValue.Text = "The SJF (Shortest Job First) scheduling algorithm is an algorithm in which the process having the smallest execution time is chosen for the next execution. This scheduling method can be preemptive or non-preemptive. It significantly reduces the average waiting time for other processes awaiting execution.";
                    break;
                case AlgorithmManager.Type.Srtf:
                    lbAlgorithmDescriptionValue.Text = "This Algorithm is the preemptive version of SJF scheduling. In SRTF, the execution of the process can be stopped after certain amount of time. At the arrival of every process, the short term scheduler schedules the process with the least remaining burst time among the list of available processes and the running process.";
                    break;
                case AlgorithmManager.Type.RoundRobin:
                    lbAlgorithmDescriptionValue.Text = "The name of this algorithm comes from the round-robin principle, where each person gets an equal share of something in turns. It is the oldest, simplest scheduling algorithm, which is mostly used for multitasking. In Round-robin scheduling, each ready task runs turn by turn only in a cyclic queue for a limited time slice.This algorithm also offers starvation free execution of processes.";
                    break;
                case AlgorithmManager.Type.Priority:
                    lbAlgorithmDescriptionValue.Text = "Priority Scheduling is a method of scheduling processes that is based on priority. In this algorithm, the scheduler selects the tasks to work as per the priority. The processes with higher priority should be carried out first, whereas jobs with equal priorities are carried out on a Round Robin or FCFS basis. Priority depends upon memory requirements, time requirements, etc...";
                    break;
                case AlgorithmManager.Type.None:
                    lbAlgorithmDescriptionValue.Text = "Select an algorithm";
                    break;
            }
        }

        /* Initializes the graph adding the basic components */
        private void InitializeGraph()
        {
            // if the graph was already painted, it clears it
            if (pnGraphic.Controls.Count > 0)
            {
                pnGraphic.Controls.Clear();
            }

            // adds all processes added by the user
            foreach(Process Proc in _activeProcesses)
            {
                // Creates the starting label that will identify the life of the process and its execution
                var ProcessLabel = new Label()
                {
                    Text = Proc.Name,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Proc.Color,
                    ForeColor = Proc.Color.GetBrightness() < 0.5 ? Color.White : Color.Black,
                    Dock = DockStyle.Left,
                    Name = $"lb{ Proc.ID }",
                    Height = Constants.GraphRowHeight,
                    Width = Constants.GraphLabelWidth
                };

                // Creates the panel timeline (which will contain all the execution blocks)
                var TimeLinePanel = new Panel()
                {
                    BackColor = Color.LightGray,
                    Dock = DockStyle.Fill,
                    Name = $"pnTimeline{ Proc.ID }",
                    Height = Constants.GraphRowHeight
                };

                // Defines a parent panel that will hold the other components
                var Row = new Panel()
                {
                    Name = $"pnRow{ Proc.ID }",
                    BackColor = Proc.Color,
                    Dock = DockStyle.Top,
                    Height = Constants.GraphRowHeight
                };

                // Defines the custom paint event for the components
                ProcessLabel.Paint += (object sender, PaintEventArgs e) =>
                {

                    ControlPaint.DrawBorder(e.Graphics, ProcessLabel.ClientRectangle,
                        Color.Black, 1, ButtonBorderStyle.None,   // left
                        Color.Black, 1, ButtonBorderStyle.None,   // top
                        Color.Black, 1, ButtonBorderStyle.Solid,  // right
                        Color.Black, 1, ButtonBorderStyle.Solid); // bottom
                };

                TimeLinePanel.Paint += (object sender, PaintEventArgs e) =>
                {
                    ControlPaint.DrawBorder(e.Graphics, TimeLinePanel.ClientRectangle,
                        Color.Black, 1, ButtonBorderStyle.None,   // left
                        Color.Black, 1, ButtonBorderStyle.None,   // top
                        Color.Black, 1, ButtonBorderStyle.None,   // right
                        Color.Black, 1, ButtonBorderStyle.Solid); // bottom
                };

                // Adds the components in reverse order
                Row.Controls.Add(TimeLinePanel);
                Row.Controls.Add(ProcessLabel);

                pnGraphic.Controls.Add(Row);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfirmExit() == DialogResult.Yes)
            {
                Close();
            }
        }

        /* Confirms exiting, changeable via settings */
        private DialogResult ConfirmExit()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit??", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            return result;
        }

        private void IOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Opens settings on tool strip click
            new SettingsForm().ShowDialog();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog()
            {
                RootFolder = Environment.SpecialFolder.Desktop,
                Description = "Select the location where to save the exported file:"
            };

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            using (StreamWriter writer = File.AppendText(dialog.SelectedPath + $"\\Processes_{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}.prc"))
            {
                // Writes file header
                writer.WriteLine($"#{cbAlgorithm.SelectedIndex};{cbContextSwitch.Checked};{cbModeSwitch.Checked};");

                foreach (Process proc in _activeProcesses)
                {
                    writer.WriteLine(proc.ToCSV());
                }
            }

            MessageBox.Show("Processes successfully exported!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Loads a saved file into the application
        private void LoadFile(string path)
        {
            bool hasErrors = false;

            List<Process> loadedProcess = new List<Process>();

            using (StreamReader reader = new StreamReader(File.OpenRead(path)))
            {
                while (!reader.EndOfStream)
                {
                    string StrProcess = reader.ReadLine();
                    string[] values = StrProcess.Split(';');

                    try
                    {
                        if (StrProcess[0] == '#')
                        {
                            cbAlgorithm.SelectedIndex = int.Parse(values[0].Trim('#'));
                            cbContextSwitch.Checked = bool.Parse(values[1]);
                            cbModeSwitch.Checked = bool.Parse(values[2]);
                            continue;
                        }

                        // Creates new process
                        Process proc = new Process(values[0], int.Parse(values[2]), int.Parse(values[3]), values[1])
                        {
                            Color = Color.FromArgb(int.Parse(values[4]), int.Parse(values[5]), int.Parse(values[6]))
                        };

                        proc.SetPriority(int.Parse(values[7]));
                        proc.SetMode(bool.Parse(values[8]));

                        loadedProcess.Add(proc);
                    }
                    catch (FormatException)
                    {
                        hasErrors = true;
                        continue;
                    }
                    catch(Exception)
                    {
                        MessageBox.Show($"The file {path} is not valid!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Handles the new list size
                    if (loadedProcess.Count >= Constants.MaxProcesses)
                    {
                        MessageBox.Show($"In the file there are more than {Constants.MaxProcesses} processes. It has been loaded only the maximum amount.", "Too many files", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                }

                // The min size has to be checked last since the program can't know when the file is finished until it finishes reading it
                if (loadedProcess.Count < Constants.MinProcesses)
                {
                    MessageBox.Show($"In the file there are less than {Constants.MinProcesses} processes. Try exporting a configuration with enought processes.", "Not enough files", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Handles possible corrupted processes in the file
                if (hasErrors)
                {
                    MessageBox.Show($"One or more processes in the file \"{path}\" have been modified/corrupted.\nTry exporting the configuration again.", "Save corrupted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Clears the old process list
            lvProcesses.RemoveAllProcesses();
            _activeProcesses.Clear();

            // Updates the process list
            foreach(Process Proc in loadedProcess)
            {
                AddProcess(Proc);
            }
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog()
            {
                CheckFileExists = true,
                Filter = "Process list files (*.prc)|*.prc",
                Title = "Select a process list file",
                Multiselect = false,
                InitialDirectory = Environment.SpecialFolder.Desktop.ToString()
            };

            dialog.ShowDialog();

            if (!string.IsNullOrEmpty(dialog.FileName))
            {
                LoadFile(dialog.FileName);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpForm().ShowDialog();
        }

        private void lvProcesses_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lvProcesses_DragDrop(object sender, DragEventArgs e)
        {
            string droppedFile = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

            if (!string.IsNullOrEmpty(droppedFile))
            {
                LoadFile(droppedFile);
            }
        }

        /* Labels explainations
         * TODO:
         * Implement tips/explainations in a separate class
         */
        private void lbCpuUsage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The CPU usage is a value that mesures how much the CPU has worked in a time span. Its value can vary from 0 to 100%, the higher the better.", "CPU Utilization",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lbThroughput_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The throughput is the amount of work done per unit of time.", "CPU throughput",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lbWaitingTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The waiting time is the time spent by a process in the ready queue. Every process has its own waiting time but this value takes in consideration all processes' waiting times.", "CPU throughput",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lbTotalTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The total duration of the scheduling. (From the 0 time unit from the last process execution).", "Total Time",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lbTotalBurst_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The total amount of time in which the CPU has been busy executing a process.", "CPU Burst",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ConfirmOnExit)
            {
                return;
            }

            if (ConfirmExit() == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
