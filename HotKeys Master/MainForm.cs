using HotKeys_Master.Models;
using HotKeys_Master.UserControls;

namespace HotKeys_Master
{
    public partial class MainForm : Form
    {
        UC_Home UC_Home = new UC_Home();
        UC_Settings UC_Settings = new UC_Settings();
        UC_About UC_About = new UC_About();

        public MainForm()
        {
            InitializeComponent();
            UserController.Add(MainContent, UC_Home);
        }

        private void PanelVisibleReset()
        {
            LeftPanel1.Visible = false;
            LeftPanel2.Visible = false;
            LeftPanel3.Visible = false;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            UserController.Add(MainContent, UC_Home);
            PanelVisibleReset();
            LeftPanel1.Visible = true;
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            UserController.Add(MainContent, UC_Settings);
            PanelVisibleReset();
            LeftPanel2.Visible = true;
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            UserController.Add(MainContent, UC_About);
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
    }
}
