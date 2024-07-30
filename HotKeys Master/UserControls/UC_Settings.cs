using Guna.UI2.WinForms;
using HotKeys_Master.Models;


namespace HotKeys_Master.UserControls
{
    public partial class UC_Settings : UserControl
    {
        SettingsObjects Settings = new SettingsObjects();

        private const string _jsonFileName = "Settings.json";

        public UC_Settings()
        {
            InitializeComponent();

            try
            {
                SetSettings();
            }
            catch
            {
                File.Delete(_jsonFileName);
            }
        }

        private void SetSettings()
        {
            var themeIsDark = Json.DeserializeObject(out Settings, _jsonFileName).DarkThemeEnabled;
            var launchAtStartup = Json.DeserializeObject(out Settings, _jsonFileName).LaunchAtStartupEnabled;
            var sendNotify = Json.DeserializeObject(out Settings, _jsonFileName).NotificationEnabled;

            SetToggleSwitchFromJson(ThemeSwitcher, themeIsDark);
            SetToggleSwitchFromJson(StartupSwitcher, launchAtStartup);
            SetToggleSwitchFromJson(NotificationSwitcher, sendNotify);
        }

        private void SetToggleSwitchFromJson(Guna2ToggleSwitch toggleSwitch, bool deserializedObject)
        {
            if (deserializedObject == true)
            {
                toggleSwitch.Animated = false;
                toggleSwitch.Checked = true;
            }
        }

        private void ToggleSwitcher(Guna2ToggleSwitch toggleSwitch)
        {
            if (toggleSwitch.Checked == false)
                toggleSwitch.Animated = true;
        }

        private void ThemeSwitcher_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSwitcher(ThemeSwitcher);

            Settings.DarkThemeEnabled = ThemeSwitcher.Checked;
            Json.SerializeObject(Settings, _jsonFileName);
        }

        private void StartupSwitcher_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSwitcher(StartupSwitcher);

            Settings.LaunchAtStartupEnabled = StartupSwitcher.Checked;
            Json.SerializeObject(Settings, _jsonFileName);
        }

        private void NotificationSwitcher_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSwitcher(NotificationSwitcher);

            Settings.NotificationEnabled = NotificationSwitcher.Checked;
            Json.SerializeObject(Settings, _jsonFileName);
        }
    }
}
