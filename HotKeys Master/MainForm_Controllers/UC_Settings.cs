using HotKeys_Master.Models;
using HotKeys_Master.Models.Jsons;


namespace HotKeys_Master.UserControls
{
    public partial class UC_Settings : UserControl
    {
        Settings Settings = new Settings();

        public UC_Settings()
        {
            InitializeComponent();

            try
            {
                Settings.SetControls();
            }
            catch
            {
                File.Delete(JsonFileNames.Settings);
            }
        }

        private void ThemeSwitcher_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ToggleSwitcher(Theme_Switcher, value => Settings.IsDarkThemeEnabled = value);
            Json.SerializeObject(Settings, JsonFileNames.Settings);
        }

        private void StartupSwitcher_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ToggleSwitcher(Startup_Switcher, value => Settings.IsLaunchAtStartupEnabled = value);
            Json.SerializeObject(Settings, JsonFileNames.Settings);
        }

        private void NotificationSwitcher_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ToggleSwitcher(Notification_Switcher, value => Settings.IsNotificationsEnabled = value);
            Json.SerializeObject(Settings, JsonFileNames.Settings);
        }

        private void HideWindow_Switcher_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ToggleSwitcher(HideWindow_Switcher, value => Settings.IsHideOnCloseEnabled = value);
            Json.SerializeObject(Settings, JsonFileNames.Settings);
        }
    }
}
