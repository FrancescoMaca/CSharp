
namespace CPU_Scheduler
{
    /***********************************************************
     * Main file for application basic settings. DO NOT MODIFY
     ***********************************************************
     */
    static class Constants
    {
        /* Application settings:
         * inDevelopment:
         *      Application status (true = WIP, false = OK).
         */
        public const bool inDevelopment = false;

        /*
         * Logic settings:
         * MaxProcesses:
         *      Maximum amount of processes allowed by the program.
         * MinProcesses:
         *      Minimum amount of process allowed by the program.
         */
        public const int MaxProcesses = 6;
        public const int MinProcesses = 1;

        /*
         * Design settings:
         * GraphProcessView:
         *      Number of processes saw at once by the graph panel.
         * GraphRowHeight:
         *      Height (in pixels) of each graph row.
         * GraphLabelWidth:
         *      The width of the process name's label on the graph.
         * GraphDefaultColor:
         *      Default panel's back color, default is Color.LightGray.
         * GraphRightOffset:
         *      The right-hand offset distance (in pixel) from the panel's border.
         *      Used to keep the graph cleaner without having processes finishing exactly on the panel's border.
         * GraphContextSwitchTime:
         *      The value of the context switch in time units.
         * GraphContextSwitchColor:
         *      Default Context Switch line color, default value is '0xc91e1e'.
         * GraphModeSwitchWidth:
         *      The width of the kernel-user mode switch line.
         * GraphModeSwitchColor:
         *      Default Kernel-User mode Switch line color, default value is '0x004dbf'.
         */
        public const int GraphProcessView = 6;
        public const int GraphRowHeight = 30;
        public const int GraphLabelWidth = 130;
        public const int GraphDefaultColor = 0xd3d3d3;
        public const int GraphRightOffset = 45;
        public const int GraphContextSwitchTime = 1;
        public const int GraphContextSwitchColor = 0xc91e1e;
        public const int GraphModeSwitchTime = 1;
        public const int GraphModeSwitchColor = 0x004dbf;

        /*
         * Linked resources:
         * Last update:
         *      (06-21-21)
         */
        public const string UrlGithub = "https://github.com/FrancescoMaca";
        public const string UrlLinkedin = "https://www.linkedin.com/in/francesco-macaluso/";
        public const string UrlInstagram = "https://www.instagram.com/franky_maca/";

        /*
         * Process settings:
         * ProcessDefaultColor:
         *      The default color of a process used on creation, the default is Color.LightSlateGray.
         * ProcessIDCharset:
         *      The char used to create the processID.
         * ProcessIDLength:
         *      The process ID length.
         * ProcessNameMinLength:
         *      Minimum process name allowed length.
         * ProcessNameMaxLength:
         *      Maximum process name length.
         * ProcessKernelSign:
         *      The default process name sign that tells you the process will be run in kernel mode. Default value is \u2605 (★)
         */
        public const int ProcessDefaultColor = 0x778899;
        public const string ProcessIDCharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public const int ProcessIDLength = 16;
        public const int ProcessNameMinLength = 3;
        public const int ProcessNameMaxLength = 16;
        public const char ProcessKernelSign = '\u2605';

    }
}
