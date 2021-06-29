using System.Windows.Forms;
using System.Configuration;

namespace CPU_Scheduler
{
    /*
    * Main I/O to resource file. Not working, needs to be finished.
    */
    public static class SettingsManager
    {
        public static void Write(string Attribute, string Value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[Attribute] == null)
            {
                settings.Add(Attribute, Value);
            }
            else
            {
                settings[Attribute].Value = Value;
            }

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        public static string Read(string Attribute)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                return appSettings[Attribute];
            }
            catch (ConfigurationErrorsException e)
            {
                MessageBox.Show(e.Message, "An error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
