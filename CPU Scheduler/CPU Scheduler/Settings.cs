using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace CPU_Scheduler
{
    /*
     * Contains all settings option for this application.
     * 
     * THIS CLASS IS WIP
     */
    public partial class SettingsForm : Form
    {
        // Defining the two themes
        public enum Theme
        {
            LIGHT, DARK
        }

        /*
         * Used to check if the user selection is different then
         * the current active theme.
         */
        private readonly Theme _systemTheme;

        // Temporary variable to save changes
        private string SavePath;
        private bool ConfirmOnExit;

        /*
         * TODO:
         * Rewrite names that follows C# naming convention DONE
         * Chnage the theme in every UI component TODO
         * Add %AppData% file for settings save TODO
         * Implement basic user settings DONE
         * Develop a testing purpose console TODO
         */
        public SettingsForm()
        {
            InitializeComponent();

            // Form settings
            MaximizeBox = false;

            // Theme initialization
            if (_systemTheme == Theme.LIGHT)
            {
                rbThemeColorLight.Checked = true;
                rbThemeColorDark.Checked = false;
            }
            else
            {
                rbThemeColorLight.Checked = false;
                rbThemeColorDark.Checked = true;
            }

            // Settings initialization
            tbSavepath.Text = MainWindow.SavePath;
            cbConfirmExit.Checked = MainWindow.ConfirmOnExit;
        }

        private void cbConfirmExit_CheckedChanged(object sender, EventArgs e)
        {
            ConfirmOnExit = cbConfirmExit.Checked;
        }

        private void btBrowseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog()
            {
                RootFolder = Environment.SpecialFolder.Desktop,
                Description = "Select the folder in which to save files:"
            };

            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SavePath = dialog.SelectedPath;
            }
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            SaveChanges();
            Close();
        }

        private void SaveChanges()
        {
            // If the SavePath has been changed then it overwrites the other values
            if (!string.IsNullOrEmpty(SavePath))
            {
                tbSavepath.Text = SavePath;
                MainWindow.SavePath = SavePath;
            }

            MainWindow.ConfirmOnExit = ConfirmOnExit;
        }
    }
}
