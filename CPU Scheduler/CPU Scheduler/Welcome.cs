using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduler
{
    /* Temporary class */
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();

            // Little EE
            pbGif.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lbEmail_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbEmail.Text);
            ttEmailCopied.Show("Email copied!", this, new Point(310, 170));
        }
    }
}
