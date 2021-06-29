# CPU Scheduler
## What is it??
This application simulates some of the algorithms that the CPU uses to schedlue the execution of processes. This application is still in beta, some features like the dark-light mode and the SRTF algorithm don't work!

## How to use it??
It's really simple to use this program. I think the UI is pretty intuitive.

<img src="https://github.com/FrancescoMaca/FrancescoMaca/blob/main/images/CPUScheduler_Settings.png" alt="CPU Scheduling Settings Tab">
This is the settings tab, it contains the type of the algorithm you want to test, the time slice (which is only used in the Round Robin scheduling) and the dispatcher options.

The algorithms you can choose from are:
- FCFS / First-Come-First-Served

- SJF / Shortest-Job-First

- SRTF / Shortest-Remaining-Time-First

- Round Robin

- Priority


The options the dispatcher has are: 

- Context switch

- User-Kernel mode switch

Both are flags that tells the program if it should considered the time taken by the CPU to switch between processes (`context switch`) or to switch between processes with
different privileges (`User-Kernel mode switch`).

---

<img src="https://github.com/FrancescoMaca/FrancescoMaca/blob/main/images/CPUScheduler_process.png" alt="CPU Scheduling Process Tab">

This is the process list view tab, which contains all the process you will give to the scheduling algorithm.
## Bugs

_- The graph can be buggy when resizing the window._

_- The "Clear" button doesn't remove the context/mode swtich._

_- There is no "external saving" file, the plan was to use the settings.xml to save a file with the settings in %appdata%._

