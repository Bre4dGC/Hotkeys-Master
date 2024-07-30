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
            var hotkeyForm = new CreateHotkeyForm();
            hotkeyForm.ShowDialog();
        }
    }
}
