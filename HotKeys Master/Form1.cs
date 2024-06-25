﻿using System.Diagnostics;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using Guna.UI2.WinForms;
using HotKeys_Master.UserControls;

namespace HotKeys_Master
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            MainContent.Controls.Clear();
            MainContent.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void PanelVisibleReset()
        {
            LeftPanel1.Visible = false;
            LeftPanel2.Visible = false;
            LeftPanel3.Visible = false;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            AddUserControl(uc);
            PanelVisibleReset();
            LeftPanel1.Visible = true;
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            UC_Settings uc = new UC_Settings();
            AddUserControl(uc);
            PanelVisibleReset();
            LeftPanel2.Visible = true;
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            UC_About uc = new UC_About();
            AddUserControl(uc);
            PanelVisibleReset();
            LeftPanel3.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Hotkey Master";
            notifyIcon1.BalloonTipText = "The application has switched to background mode";
            notifyIcon1.Text = "Hotkey Master";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }
    }
}
