using HotKeys_Master.Models.Hotkey;
using HotKeys_Master.Models.Jsons;
using HotKeys_Master.UserControls;
using System.Diagnostics;

namespace HotKeys_Master.CreateForm_Controllers
{
    public partial class UC_AddHotkeyPath : UserControl
    {
        private string _filePath;
        private string _url;

        private Hotkeys _hotkeys = new Hotkeys();

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
            try
            {
                var deserializedHotkeysList = Json.DeserializeObject(out _hotkeys, JsonFileNames.Hotkeys).List;
                _hotkeys.List.Union(deserializedHotkeysList);
            }
            catch
            {
                Json.SerializeObject(_hotkeys, JsonFileNames.Hotkeys);
            }
            finally
            {
                Hotkey hotkey;
                if (combobox.SelectedIndex == 0)
                {
                    hotkey = new Hotkey(_firstKey, _secondKey, _lastKey, Path.GetFileNameWithoutExtension(_filePath), _filePath);
                    UC_Home.AddHotkeysPanel(hotkey, hotkey.Title);

                    _hotkeys.List.Add(hotkey);
                }
                else if (combobox.SelectedIndex == 1)
                {
                    hotkey = new Hotkey(_firstKey, _secondKey, _lastKey, Path.GetFileNameWithoutExtension(_filePath), _url);
                    UC_Home.AddHotkeysPanel(hotkey, hotkey.Title);

                    _hotkeys.List.Add(hotkey);
                }

                Json.SerializeObject(_hotkeys, JsonFileNames.Hotkeys);
            }

            Form parentForm = this.FindForm();
            parentForm.Close();
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
                DragDrop_panel.Visible = true;
                UrlPath_textbox.Visible = false;
                Check_btn.Visible = false;
            }

            if (combobox.SelectedIndex == 1)
            {
                DragDrop_panel.Visible = false;
                UrlPath_textbox.Visible = true;
                Check_btn.Visible = true;
            }
        }
        private void guna2Panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void guna2Panel1_DragDrop(object sender, DragEventArgs e)
        {
            _filePath = e.Data.GetData(DataFormats.FileDrop).ToString();
        }


        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable files|*.exe|All files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filePath = openFileDialog.FileName;
                label1.Text = Path.GetFileNameWithoutExtension(_filePath);
            }
        }

        private void UrlPath_textbox_TextChanged(object sender, EventArgs e)
        {
            Check_btn.Enabled = UrlPath_textbox.TextLength >= 5 ? true : false;
            _url = UrlPath_textbox.Text;
        }
    }
}
