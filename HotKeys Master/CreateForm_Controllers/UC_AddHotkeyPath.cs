 using HotKeys_Master.Models.Hotkey;
using HotKeys_Master.Models.Jsons;
using System.Diagnostics;

namespace HotKeys_Master.CreateForm_Controllers
{
    public partial class UC_AddHotkeyPath : UserControl
    {
        private string _filePath;
        private string _url;

        private Hotkeys Hotkeys = new Hotkeys();

        private Keys _firstKey { get; }
        private Keys _secondKey { get; }
        private Keys _lastKey { get; }

        public UC_AddHotkeyPath(Keys firstKey, Keys secondKey, Keys lastKey)
        {
            InitializeComponent();

            _firstKey = firstKey;
            _secondKey = secondKey;
            _lastKey = lastKey;
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            if (combobox.SelectedIndex == 0)
            {
                Hotkeys.List.Add(new Hotkey(_firstKey, _secondKey, _lastKey, ""));
            }
            else if (combobox.SelectedIndex == 1)
            {
                Hotkeys.List.Add(new Hotkey(_firstKey, _secondKey, _lastKey, ""));
            }

            Json.SerializeObject(Hotkeys, JsonFileNames.Hotkeys);
        }

        private void Check_btn_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start {UrlPath_textbox.Text}"
            });
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox.SelectedIndex == 0)
            {
                label1.Visible = true;
                guna2Panel1.Visible = true;
                UrlPath_textbox.Visible = false;
                Check_btn.Visible = false;
            }

            if (combobox.SelectedIndex == 1)
            {
                guna2Panel1.Visible = false;
                UrlPath_textbox.Visible = true;
                Check_btn.Visible = true;
            }
        }

        private void guna2Panel1_DragDrop(object sender, DragEventArgs e)
        {
            _filePath = e.Data.GetData(DataFormats.FileDrop).ToString();
        }

        private void guna2Panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.exe*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filePath = openFileDialog.FileName;
            }
        }
    }
}
