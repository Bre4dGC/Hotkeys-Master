using HotKeys_Master.Models.Hotkey;

namespace HotKeys_Master.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var hotkeyForm = new CreateForm();
            hotkeyForm.ShowDialog();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            
        }
    }
}
