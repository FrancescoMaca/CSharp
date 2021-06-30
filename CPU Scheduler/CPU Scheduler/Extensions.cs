using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace CPU_Scheduler
{
    /*
     * This class contains useful extensions made by me and taken from the internet.
     * (All non-mine code will be commented and linked the original source)
     */
    public static class Extensions
    {
        

        /*
         * Returns a list of all specific type of a control
         */
        public static IEnumerable<Control> GetAll(this Control control, System.Type type)
        {
            // Original code: -> https://stackoverflow.com/a/3426721
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public static void AddProcess(this ListView view, Process NewProcess)
        {
            // If the process runs in kernel-mode then it has the star near its name
            string itemName = NewProcess.Name + (NewProcess.IsKernel ? $" {Constants.ProcessKernelSign}" : "");

            // Creating a new ListView item
            ListViewItem newItem = new ListViewItem(itemName, NewProcess.ID);

            newItem.SubItems.Add(NewProcess.Arrival.ToString());
            newItem.SubItems.Add(NewProcess.Duration.ToString());
            newItem.SubItems.Add(NewProcess.ID);
            newItem.BackColor = NewProcess.Color;
            newItem.ForeColor = NewProcess.Color.GetBrightness() < 0.5 ? Color.White : Color.Black;

            // Adding it to the list view
            view.Items.Add(newItem);
        }

        public static void RemoveProcess(this ListView view)
        {
            if (view.Items.Count <= 0)
            {
                return;
            }

            // If there are no selected processes then removes the last process
            if (view.SelectedItems.Count == 0)
            {
                view.Items.RemoveAt(view.Items.Count - 1);
                return;
            }

            // Removes all selected process
            foreach (ListViewItem selectedItem in view.SelectedItems)
            {
                view.Items.Remove(selectedItem);
            }
        }

        public static void RemoveAllProcesses(this ListView view)
        {
            while (view.Items.Count > 0)
            {
                view.RemoveProcess();
            }
        } 
    }
}
