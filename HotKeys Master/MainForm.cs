using HotKeys_Master.Models;
using HotKeys_Master.Models.Hotkey;
using HotKeys_Master.Models.Jsons;
using HotKeys_Master.UserControls;
using System.Diagnostics;
using Gma.System.MouseKeyHook;

namespace HotKeys_Master
{
    public partial class MainForm : Form
    {
        private static IKeyboardMouseEvents _globalHook;

        UC_Home UC_Home = new UC_Home();
        UC_Settings UC_Settings = new UC_Settings();
        UC_About UC_About = new UC_About();

        public MainForm()
        {
            InitializeComponent();

            UserController.Add(Content, UC_Home);
        }

        private void PanelVisibleReset()
        {
            LeftPanel1.Visible = false;
            LeftPanel2.Visible = false;
            LeftPanel3.Visible = false;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            UserController.Add(Content, UC_Home);
            PanelVisibleReset();
            LeftPanel1.Visible = true;
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            UserController.Add(Content, UC_Settings);
            PanelVisibleReset();
            LeftPanel2.Visible = true;
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            UserController.Add(Content, UC_About);
            PanelVisibleReset();
            LeftPanel3.Visible = true;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Notify.Visible = false;
            //Application.Exit();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Show();
            //this.WindowState = FormWindowState.Normal;
            //this.ShowInTaskbar = true;
        }

        private void Notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //this.Show();
            //this.WindowState = FormWindowState.Normal;
            //this.ShowInTaskbar = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //this.Hide();
            //this.ShowInTaskbar = false;
            //Notify.ShowBalloonTip(500);
        }

        private void Jopa(object sender, KeyEventArgs e)
        {
            Keys firstKey = Keys.None;
            Keys secondKey = Keys.None;
            Keys lastKey = Keys.None;

            var hotkeys = new Hotkeys();

            var hotkeysList = Json.DeserializeObject(out hotkeys, JsonFileNames.Hotkeys).List;

            if(e.Control || e.Alt)
            {
                firstKey = e.Control ? Keys.Control : (e.Alt ? Keys.Alt : (e.Shift ? Keys.Shift : Keys.None));

                secondKey = Keys.None;
                lastKey = Keys.None;
            }

            if (firstKey is not Keys.None && e.Control || e.Shift || e.Alt)
            {
                secondKey = (e.Control && e.Alt) ? Keys.Alt : (e.Control && e.Shift) ? Keys.Shift : (e.Alt && e.Shift) ? Keys.Shift : Keys.None;

                lastKey = Keys.None;
            }

            var isLetterKeys = e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z;
            var isNumPadKeys = e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9;
            var isFuncKeys = e.KeyCode >= Keys.F1 && e.KeyCode <= Keys.F24;

            if (firstKey is not Keys.None && secondKey is not Keys.None && (isLetterKeys || isNumPadKeys || isFuncKeys))
            {
                lastKey = e.KeyCode;
            }

            if(firstKey is not Keys.None && secondKey is not Keys.None && lastKey is not Keys.None)
            {
                var hotkey = new Hotkey(firstKey, secondKey,lastKey);

                foreach (Hotkey hotkey1 in hotkeysList)
                {
                    if (hotkey == hotkey1)
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd",
                            Arguments = $"/c start {hotkey1.Path}"
                        });
                    }
                }
            }
        }
    }
}
