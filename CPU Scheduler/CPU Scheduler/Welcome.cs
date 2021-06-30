using System;
using System.Drawing;
using System.Windows.Forms;

namespace CPU_Scheduler
{
    /* 
     * Temporary class, when the application is WIP marked, it displays the current window
     */
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();

            // Funny gif
            pbGif.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lbEmail_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbEmail.Text);
            ttEmailCopied.Show("Email copied!", this, new Point(310, 170));
        }
    }
}
