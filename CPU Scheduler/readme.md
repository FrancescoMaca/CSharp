# CPU Scheduler
## What is it??
This application simulates some of the algorithms that the CPU uses to schedlue the execution of processes. This application is still in beta, some features like the dark-light mode and the SRTF algorithm don't work!

## How to use it??
It's really simple to use this program. I think the UI is pretty intuitive.

<img src="https://github.com/FrancescoMaca/FrancescoMaca/blob/main/images/CPU_Scheduler_Settings.png" alt="CPU Scheduling Settings Tab">
This is the settings tab, it contains the type of the algorithm you want to test, the time slice (which is only used in the Round Robin scheduling) and the dispatcher options.
The algorithms you can choose from are: <br /> <br />

🔵 FCFS / First-Come-First-Served

🔵 SJF / Shortest-Job-First

🔵 SRTF / Shortest-Remaining-Time-First

🔵 Round Robin

🔵 Priority

All algorithms have their own description built-in in the application, but if you want to learn more about them check out [this link](https://www.guru99.com/cpu-scheduling-algorithms.html). <br />
The options the dispatcher has are: 

🔵 Context switch

🔵 User-Kernel mode switch

Both are flags that tells the program if it should considered the time taken by the CPU to switch between processes (`context switch`) or to switch between processes with
different privileges (`User-Kernel mode switch`).

---

<img src="https://github.com/FrancescoMaca/FrancescoMaca/blob/main/images/CPU_Scheduler_Processes.png" alt="CPU Scheduling Process Tab">

This is the process list view tab, which contains all the process you will give to the scheduling algorithm. Each process has its own arrival time, duration and name.
They all have their own PID and I've added some esthetic features like the color and, if a process has kernel-mode enabled, it has a little star near its name.

From there you can add or remove existing processes and you can also import/export a `.prc` file with the program configuration.

---

<img src="https://github.com/FrancescoMaca/FrancescoMaca/blob/main/images/CPU_Scheduler_Graph.png" alt="CPU Scheduling Graph Tab" height=350>

This is the main part of the program, it shows the scheduled processes to the user and, if the dispatcher options are checked, it also shows the context/mode switches. <br />
Choosing an algorithm it will show its description below the graph. Some of these descriptions *are taken from the interent*. <br />
When you run an algorithm it reports its statistics below the graph. You can retrive data like the `total duration` of the scheduling, the `throughput`, the `CPU utilization`, etc... <br /> <br />
The file used for taking pictures will be in the directory of the project (`config.prc`).<br />

## Bugs
The program is still in beta, so most of the bugs are not mentioned here, i just wrote down the most noticeable. <br /> The color changes based on the problem size.

🔴 _The graph can be buggy when resizing the window._

🟢 _The "Clear" button doesn't remove the context/mode swtich._

🟠 _There is no "external saving" file, the plan was to use the settings.xml to save a file with the settings in %appdata%._

## Version 1.0.1
