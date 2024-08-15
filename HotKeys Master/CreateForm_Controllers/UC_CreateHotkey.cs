using HotKeys_Master.Models;
using System.Windows.Forms;

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

            OutputKeyValue();

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
            if (e.Control || e.Alt)
            {
                FirstKey = e.Control ? Keys.Control : (e.Alt ? Keys.Alt : (e.Shift ? Keys.Shift : Keys.None));

                SecondKey = Keys.None;
                LastKey = Keys.None;
            }
        }

        private void CreateSecondKey(KeyEventArgs e)
        {
            if (FirstKey is not Keys.None && e.Control || e.Shift || e.Alt)
            {
                SecondKey = (e.Control && e.Alt) ? Keys.Alt : (e.Control && e.Shift) ? Keys.Shift : (e.Alt && e.Shift) ? Keys.Shift : Keys.None;

                LastKey = Keys.None;
            }
        }

        private void CreateLastKey(KeyEventArgs e)
        {
            if (FirstKey is not Keys.None && SecondKey is not Keys.None && e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
            {
                LastKey = e.KeyCode;
            }
        }

        private void OutputKeyValue()
        {
            string keyData = (FirstKey is not Keys.None ? GetKeyName(FirstKey) + " + " : "") +
                                 (SecondKey is not Keys.None ? SecondKey.ToString() + " + " : "") +
                                 (LastKey is not Keys.None && LastKey != Keys.Menu && LastKey != Keys.ShiftKey ? LastKey.ToString() : "");

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
    }
}
