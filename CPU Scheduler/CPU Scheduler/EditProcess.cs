using System;
using System.Windows.Forms;

namespace CPU_Scheduler
{
    public partial class EditProcessForm : Form
    {
        private readonly Process LinkedProcess;

        public EditProcessForm(Process LinkedProcess)
        {
            this.LinkedProcess = LinkedProcess;

            // Initialize the UI
            InitializeComponent();
        }

        private void EditProcessForm_Load(object sender, EventArgs e)
        {
            // Setting up windows name, colors and other details
            Text = "Editing \"" + LinkedProcess.Name + "\"";

            // Process name text
            lnkProcessName.Text = LinkedProcess.Name;
            
            // Panel color
            pnCurrentColor.BackColor = LinkedProcess.Color;
            
            // Cool feature: linked label click matches the process color
            lnkProcessName.ActiveLinkColor = LinkedProcess.Color;
            
            // Process ID
            lbProcessID.Text += LinkedProcess.ID;

            // Converts the process values for the UI
            tbArrivalTime.Text = LinkedProcess.Arrival.ToString();
            tbDuration.Text = LinkedProcess.Duration.ToString();

            // Loads the process permission
            cbMode.SelectedIndex = LinkedProcess.IsKernel ? 1 : 0;

            UpdatePriority();
        }

        private void btDone_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbDuration.Text, out int DurationTime) || !int.TryParse(tbArrivalTime.Text, out int ArrivalTime))
            {
                MessageBox.Show("You've entered a not numerical value!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else if (DurationTime <= 0)
            {
                MessageBox.Show("The inputs cannot be negative or equal to zero!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (DurationTime > 100)
            {
                DurationTime = 99;
            }

            Process.Overwrite(DurationTime, ArrivalTime, LinkedProcess);

            Close();
        }

        private void btColorPicker_Click(object sender, EventArgs e)
        {
            PickColor();
        }

        private void lnkProcessName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form changeTitle = new ChangeNameForm(LinkedProcess);

            changeTitle.ShowDialog();

            lnkProcessName.Text = LinkedProcess.Name;
            lnkProcessName.Refresh();
        }

        private void pnCurrentColor_Click(object sender, EventArgs e)
        {
            PickColor();
        }

        private void PickColor()
        {
            // Creating the color dialog
            ColorDialog colorDialog = new ColorDialog();

            // Showing the user the dialog
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // UI refresh 
                pnCurrentColor.BackColor = colorDialog.Color;
                pnCurrentColor.Refresh();

                // Setting the process color again
                LinkedProcess.Color = colorDialog.Color;

                // Modifying windows details
                lnkProcessName.ActiveLinkColor = colorDialog.Color;
                lnkProcessName.Refresh();
            }
        }

        private void btIncreasePriority_Click(object sender, EventArgs e)
        {
            LinkedProcess.PriorityUp();
            UpdatePriority();
        }

        private void btDecreasePriority_Click(object sender, EventArgs e)
        {
            LinkedProcess.PriorityDown();
            UpdatePriority();
        }

        private void UpdatePriority()
        {
            lbPriorityValue.Text = LinkedProcess.Priority.ToString();
        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMode.SelectedIndex == 1)
            {
                LinkedProcess.SetMode(true);
            }
            else
            {
                LinkedProcess.SetMode(false);
            }
        }
    }
}
