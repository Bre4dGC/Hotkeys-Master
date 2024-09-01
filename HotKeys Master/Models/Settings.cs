using Guna.UI2.WinForms;
using HotKeys_Master.Models.Jsons;
using HotKeys_Master.UserControls;

namespace HotKeys_Master.Models
{
    internal class Settings
    {
        public bool IsDarkThemeEnabled { get; set; }
        public bool IsLaunchAtStartupEnabled { get; set; }
        public bool IsNotificationsEnabled { get; set; }
        public bool IsHideOnCloseEnabled { get; set; }

        public void SetControls()
        {
            var deserializedSettings = Json.DeserializeObject(out Settings settings, JsonFileNames.Settings);

            SetToggleSwitchFromJson(UC_Settings.Theme_Switcher, deserializedSettings.IsDarkThemeEnabled);
            SetToggleSwitchFromJson(UC_Settings.Startup_Switcher, deserializedSettings.IsLaunchAtStartupEnabled);
            SetToggleSwitchFromJson(UC_Settings.Notification_Switcher, deserializedSettings.IsNotificationsEnabled);
            SetToggleSwitchFromJson(UC_Settings.HideWindow_Switcher, deserializedSettings.IsHideOnCloseEnabled);
        }

        public void ToggleSwitcher(Guna2ToggleSwitch toggleSwitch, Action<bool> settings)
        {
            if (toggleSwitch.Checked == false)
            {
                toggleSwitch.Animated = true;
            }

            settings(toggleSwitch.Checked);
        }

        private void SetToggleSwitchFromJson(Guna2ToggleSwitch toggleSwitch, bool deserializedObject)
        {
            if (deserializedObject == true)
            {
                toggleSwitch.Animated = false;
                toggleSwitch.Checked = true;
            }
        }
    }
}
