using Guna.UI2.WinForms;
using HotKeys_Master.Models.Hotkey;
using HotKeys_Master.Models.Jsons;

namespace HotKeys_Master.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
            DeserializeHotkeys();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (var overlayForm = new OverlayForm())
            {
                overlayForm.ShowOverlay(MainForm.Content);

                using (var hotkeyForm = new CreateForm())
                {
                    hotkeyForm.ShowDialog();
                }
            }
        }
        private void DeserializeHotkeys()
        {
            try
            {
                Hotkeys hotkeys = new Hotkeys();
                List<Hotkey> hotkeysList = Json.DeserializeObject(out hotkeys, JsonFileNames.Hotkeys).List;

                foreach (var hotkey in hotkeysList)
                {
                    AddHotkeysPanel(hotkey, hotkey.Title);
                }
            }
            catch
            {
                if (File.Exists(JsonFileNames.Hotkeys))
                {
                    File.Delete(JsonFileNames.Hotkeys);
                }
            }
        }

        public static void AddHotkeysPanel(Hotkey hotkey, string title)
        {
            // Hotkey_panel
            Guna2Panel Hotkey_panel = new Guna2Panel();
            Hotkey_panel.BackColor = Color.Transparent;
            Hotkey_panel.BorderRadius = 5;
            Hotkey_panel.FillColor = Color.White;
            Hotkey_panel.BackColor = Color.Transparent;
            Hotkey_panel.Location = new Point(10, 10);
            Hotkey_panel.Margin = new Padding(7, 5, 0, 7);
            Hotkey_panel.Name = "Hotkey_panel";
            Hotkey_panel.Size = new Size(890, 110);

            // Delete_btn
            Guna2CircleButton Delete_btn = new Guna2CircleButton();
            Delete_btn.BackColor = Color.Transparent;
            Delete_btn.FillColor = Color.White;
            Delete_btn.Animated = true;
            Delete_btn.Image = Properties.Resources.free_icon_delete_709518__1_;
            Delete_btn.Location = new Point(820, 40);
            Delete_btn.Size = new Size(43, 43);
            Delete_btn.ImageSize = new Size(28, 28);
            Delete_btn.ImageAlign = HorizontalAlignment.Center;
            Delete_btn.Margin = new Padding(0);
            Delete_btn.Name = "Delete_btn";

            // Edit_btn
            Guna2CircleButton Edit_btn = new Guna2CircleButton();
            Edit_btn.BackColor = Color.Transparent;
            Edit_btn.FillColor = Color.White;
            Edit_btn.Animated = true;
            Edit_btn.Image = Properties.Resources.free_icon_pencil_1024143;
            Edit_btn.Location = new Point(760, 40);
            Edit_btn.Size = new Size(43, 43);
            Edit_btn.ImageSize = new Size(28, 28);
            Edit_btn.Margin = new Padding(0);
            Edit_btn.Name = "Edit_btn";

            // Hotkey_label
            Label Hotkey_label = new Label();
            Hotkey_label.AutoSize = true;
            Hotkey_label.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Hotkey_label.ForeColor = Color.FromArgb(68, 88, 112);
            Hotkey_label.Location = new Point(30, 37);
            Hotkey_label.Margin = new Padding(0);
            Hotkey_label.Name = "Hotkey_label";
            Hotkey_label.Size = new Size(93, 32);
            Hotkey_label.Text = $"{GetKeyName(hotkey.FirstKey)} + {hotkey.SecondKey} + {hotkey.LastKey}";

            // Title_label
            Label Title_label = new Label();
            Title_label.AutoSize = true;
            Title_label.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title_label.ForeColor = Color.FromArgb(68, 88, 112);
            Title_label.Location = new Point(320, 40);
            Title_label.Margin = new Padding(0);
            Title_label.Name = "Title_label";
            Title_label.Size = new Size(61, 32);
            Title_label.Text = title;

            // Элементы управления на панель
            Hotkey_panel.Controls.Add(Delete_btn);
            Hotkey_panel.Controls.Add(Edit_btn);
            Hotkey_panel.Controls.Add(Hotkey_label);
            Hotkey_panel.Controls.Add(Title_label);

            HotkeysList_flowpanel.Controls.Add(Hotkey_panel);
        }

        private static Dictionary<Keys, string> KeyNames = new Dictionary<Keys, string>
        {
            { Keys.Control, "Ctrl"}
        };

        private static string GetKeyName(Keys key)
        {
            return KeyNames.ContainsKey(key) ? KeyNames[key] : key.ToString();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
        }
    }
}
