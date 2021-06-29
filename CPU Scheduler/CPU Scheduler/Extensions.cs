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
        
        /// <summary>
        /// Returns the list of all controls of a component.
        /// </summary>
        /// <param name="control">The root control.</param>
        /// <param name="type">THe type of Control you're looking for.</param>
        /// <returns>Returns a list of controls of a certain type.</returns>
        public static IEnumerable<Control> GetAll(this Control control, System.Type type)
        {
            // Original code: -> https://stackoverflow.com/a/3426721
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        /// <summary>
        /// Adds a new porcess to the listview.
        /// </summary>
        /// <param name="view">The source list view.</param>
        /// <param name="NewProcess">The new process that has to be added.</param>
        public static void AddProcess(this ListView view, Process NewProcess)
        {
            string itemName = NewProcess.Name + (NewProcess.IsKernel ? $" {Constants.ProcessKernelSign}" : "");

            // Creating a new ListView item
            ListViewItem newItem = new ListViewItem(itemName, NewProcess.ID);

            // Adding fields
            newItem.SubItems.Add(NewProcess.Arrival.ToString());
            newItem.SubItems.Add(NewProcess.Duration.ToString());
            newItem.SubItems.Add(NewProcess.ID);
            newItem.BackColor = NewProcess.Color;
            newItem.ForeColor = NewProcess.Color.GetBrightness() < 0.5 ? Color.White : Color.Black;

            // Adding object to the list view
            view.Items.Add(newItem);
        }

        /// <summary>
        /// Removes the selected processes, if there are no selected processes it removes the last one.
        /// </summary>
        /// <param name="view"></param>
        public static void RemoveProcess(this ListView view)
        {
            // Checks for the size of this object
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

            // Loops through all the selected processes
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
