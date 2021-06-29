using System;
using System.Windows.Forms;

namespace CPU_Scheduler
{
    public partial class ChangeNameForm : Form
    {
        private readonly Process CurrentProcess;

        public ChangeNameForm(Process LinkedProcess)
        {
            CurrentProcess = LinkedProcess;
            InitializeComponent();
        }

        private void ChangeNameForm_Load(object sender, EventArgs e)
        {
            tbName.Text = CurrentProcess.Name;

            ActiveControl = tbName;
        }

        private void VerifyAndExit()
        {
            if (tbName.Text.Length > Constants.ProcessNameMinLength)
            {
                CurrentProcess.SetName(tbName.Text);
                Close();
            }
            else
            {
                MessageBox.Show("The name is too short!", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btChangeName_Click(object sender, EventArgs e)
        {
            VerifyAndExit();
        }

        private void tbName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerifyAndExit();
            }
        }
    }
}
