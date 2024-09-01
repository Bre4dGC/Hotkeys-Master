using HotKeys_Master.Models;
using HotKeys_Master.Models.Jsons;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotKeys_Master.CreateForm_Controllers
{
    public partial class UC_CreateHotkey : UserControl
    {
        public Keys FirstKey { get; private set; }
        public Keys SecondKey { get; private set; }
        public Keys LastKey { get; private set; }

        public UC_CreateHotkey()
        {
            InitializeComponent();
        }

        private void CreateHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;

            SetFormLabels();

            CreateFirstKey(e);
            CreateSecondKey(e);
            CreateLastKey(e);

            OutputKeysValue(e);

            if (IsHotkeyBindingNone())
            {
                PressEnter_label.Visible = true;
                OpenAddPathForm(e);
            }
        }

        private void SetFormLabels()
        {
            label.Visible = false;
            PressEnter_label.Visible = false;
            Hotkeys_label.Visible = true;
        }

        private void CreateFirstKey(KeyEventArgs e)
        {
            var isModifyKeys = e.Control || e.Alt;

            if (isModifyKeys)
            {
                FirstKey = e.Control ? Keys.Control : e.Alt ? Keys.Alt : Keys.None;

                SecondKey = Keys.None;
                LastKey = Keys.None;
            }
        }

        private void CreateSecondKey(KeyEventArgs e)
        {
            var isModifyKeys = e.Control || e.Shift || e.Alt;

            if (FirstKey is not Keys.None && isModifyKeys)
            {
                SecondKey = (e.Control && e.Alt) ? Keys.Alt : (e.Control && e.Shift) ? Keys.Shift : (e.Alt && e.Shift) ? Keys.Shift : Keys.None;

                LastKey = Keys.None;
            }
        }

        private void CreateLastKey(KeyEventArgs e)
        {
            var isLetterKeys = e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z;
            var isNumPadKeys = e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9;
            var isFuncKeys = e.KeyCode >= Keys.F1 && e.KeyCode <= Keys.F24;
            var isNumberKeys = e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9;

            if (FirstKey is not Keys.None && SecondKey is not Keys.None && (isLetterKeys || isNumPadKeys || isFuncKeys || isNumberKeys))
            {
                LastKey = e.KeyCode;
            }
        }

        private void OutputKeysValue(KeyEventArgs e)
        {
            string keyData = (FirstKey is not Keys.None ? GetKeyName(FirstKey) + " + " : "") +
                             (SecondKey is not Keys.None ? SecondKey.ToString() + " + " : "") +
                             (LastKey is not Keys.None && LastKey != Keys.Menu && LastKey != Keys.ShiftKey ? GetNumberKeyName(LastKey, e).ToString() : "");

            Hotkeys_label.Text = keyData;
        }

        private bool IsHotkeyBindingNone()
        {
            return new[] { FirstKey, SecondKey, LastKey }.All(key => key != Keys.None);
        }

        private void OpenAddPathForm(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserController.Add(CreateForm.Create_panel, new UC_AddHotkeyPath(FirstKey, SecondKey, LastKey));
            }
        }

        private Dictionary<Keys, string> KeyNames = new Dictionary<Keys, string>
        {
            { Keys.Control, "Ctrl"}
        };

        private string GetKeyName(Keys key)
        {
            return KeyNames.ContainsKey(key) ? KeyNames[key] : key.ToString();
        }

        private char GetNumberKeyName(Keys key, KeyEventArgs e)
        {
            return (char)('0' + (e.KeyCode - Keys.D0));
        }
    }
}
