namespace HotKeys_Master.Models
{
    internal class UserController
    {
        public static void Add(Panel panel, UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}
