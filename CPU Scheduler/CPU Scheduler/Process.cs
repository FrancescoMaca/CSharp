using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System;

namespace CPU_Scheduler
{
    /* 
     * Rapresent a basic process obeject.
     */
    public sealed class Process
    {
        // UID for each object
        public string ID { get; private set; }
        public string Name { get; private set; }

        public int Arrival { get; private set; }
        public int Duration { get; private set; }
        public int Priority { get; private set; }

        public bool IsKernel { get; private set; }

        public Color Color { set; get; }

        // Contains all used UIDs per program instance
        private static readonly List<string> UsedIDs;

        static Process()
        {
            UsedIDs = new List<string>();
        }

        public Process(string ID, int Arrival, int Duration)
        {
            this.ID = ID;
            this.Arrival = Arrival;
            this.Duration = Duration;

            Priority = 0;
            IsKernel = false;

            Name = "Default Process";
            Color = Color.FromArgb(255, Color.FromArgb(Constants.ProcessDefaultColor));
        }

        public Process(string ID, int Arrival, int Duration, string Name)
        {
            this.ID = ID;
            this.Arrival = Arrival;
            this.Duration = Duration;
            this.Name = Name;

            Priority = 0;
            IsKernel = false;

            Priority = 0;
            Color = Color.FromArgb(255, Color.FromArgb(Constants.ProcessDefaultColor));
        }


        public void SetPriority(int priority)
        {
            if (priority >= 0 && priority <= 9)
            {
                Priority = priority;
            }
        }

        public void PriorityUp()
        {
            if (Priority < 9)
            {
                Priority++;
            }
        }

        public void PriorityDown()
        {
            if (Priority > 0)
            {
                Priority--;
            }
        }

        public void SetMode(bool mode)
        {
            IsKernel = mode;
        }

        public void SetName(string name)
        {
            if (name.Length > Constants.ProcessNameMinLength && name.Length < Constants.ProcessNameMaxLength)
            {
                Name = name;
            }
        }

        public void SetDuration(int duration)
        {
            Duration = duration;
        }


        public static string GenerateNewID()
        {
            string NewID;

            // Creating object externally to the loops
            Random r = new Random();

            // Recreate the ID until its unique
            do
            {
                NewID = new string(Enumerable.Repeat(Constants.ProcessIDCharset, Constants.ProcessIDLength)
                    .Select(s => s[r.Next(s.Length)])
                    .ToArray());
            } while (UsedIDs.Contains(NewID));

            // Add the ID to the list
            UsedIDs.Add(NewID);

            return NewID;
        }

        public static void Overwrite(int NewDuration, int NewArrivalTime, Process OldProcess)
        {
            OldProcess.Duration = NewDuration;
            OldProcess.Arrival = NewArrivalTime;
        }
        

        // Conversion methods
        public override string ToString()
        {
            return $"Process {ID} has arrived at {Arrival} and lasted for {Duration}. It's currently running in normal mode.";
        }

        // Used to save the settings/process list into a file
        public string ToCSV()
        {
            return $"{ID};{Name};{Arrival};{Duration};{Color.R:000};{Color.G:000};{Color.B:000};{Priority};{IsKernel}";
        }
    }

    /*
     * This class rapresents a CPU burst.
     */
    public class ExecutionBlock
    {
        // The process owner of the block
        public Process Owner { get; private set; }

        // The life span of this block
        public ExecutionBlockTimeSpan Time { get; private set; }

        public ExecutionBlock(Process owner, int startTime, int endTime)
        {
            Owner = owner;
            Time = new ExecutionBlockTimeSpan(startTime, endTime);
        }

        public override string ToString()
        {
            return $"Block {{{Owner.Name} : {Time} time units}}";
        }

        /*
         * Represent a process time span.
         */
        public class ExecutionBlockTimeSpan
        {
            public int Start { get; private set; }
            public int End { get; private set; }
            public int Duration { get { return End - Start; } }

            public ExecutionBlockTimeSpan(int start, int end)
            {
                Start = start;
                End = end;
            }

            public override string ToString()
            {
                return $"{Start} -> {End}";
            }
        }
    }
}