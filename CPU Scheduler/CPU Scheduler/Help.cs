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
    public partial class HelpForm : Form
    {

        public HelpForm()
        {
            InitializeComponent();
        }

        // Opens a site on the browser
        private void GoTo(string url)
        {
            System.Diagnostics.Process.Start(url);
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            lbVersion.Text = 'v' + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void picInstagram_Click(object sender, EventArgs e)
        {
            GoTo(Constants.UrlInstagram);
        }

        private void picLinkedin_Click(object sender, EventArgs e)
        {
            GoTo(Constants.UrlLinkedin);
        }

        private void picGithub_Click(object sender, EventArgs e)
        {
            GoTo(Constants.UrlGithub);
        }
    }
}
