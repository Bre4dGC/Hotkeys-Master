namespace HotKeys_Master
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            SettingsBtn = new Guna.UI2.WinForms.Guna2Button();
            AboutBtn = new Guna.UI2.WinForms.Guna2Button();
            HomeBtn = new Guna.UI2.WinForms.Guna2Button();
            SidebarPanel = new FlowLayoutPanel();
            HomePanel = new Panel();
            LeftPanel1 = new Panel();
            SettingsPanel = new Panel();
            LeftPanel2 = new Panel();
            AboutPanel = new Panel();
            LeftPanel3 = new Panel();
            MainContent = new Panel();
            notifyIcon1 = new NotifyIcon(components);
            SidebarPanel.SuspendLayout();
            HomePanel.SuspendLayout();
            SettingsPanel.SuspendLayout();
            AboutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SettingsBtn
            // 
            SettingsBtn.Animated = true;
            SettingsBtn.BackColor = Color.White;
            SettingsBtn.CheckedState.FillColor = SystemColors.ButtonShadow;
            SettingsBtn.Cursor = Cursors.Hand;
            SettingsBtn.CustomizableEdges = customizableEdges1;
            SettingsBtn.DisabledState.BorderColor = Color.DarkGray;
            SettingsBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            SettingsBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SettingsBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SettingsBtn.FillColor = Color.White;
            resources.ApplyResources(SettingsBtn, "SettingsBtn");
            SettingsBtn.ForeColor = Color.FromArgb(75, 75, 75);
            SettingsBtn.HoverState.FillColor = Color.FromArgb(241, 241, 241);
            SettingsBtn.Image = (Image)resources.GetObject("SettingsBtn.Image");
            SettingsBtn.ImageAlign = HorizontalAlignment.Left;
            SettingsBtn.ImageSize = new Size(45, 45);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.PressedColor = Color.DarkGray;
            SettingsBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SettingsBtn.Click += SettingsBtn_Click;
            // 
            // AboutBtn
            // 
            AboutBtn.Animated = true;
            AboutBtn.BackColor = Color.White;
            AboutBtn.CheckedState.FillColor = SystemColors.ButtonShadow;
            AboutBtn.Cursor = Cursors.Hand;
            AboutBtn.CustomizableEdges = customizableEdges3;
            AboutBtn.DisabledState.BorderColor = Color.DarkGray;
            AboutBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            AboutBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AboutBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AboutBtn.FillColor = Color.White;
            resources.ApplyResources(AboutBtn, "AboutBtn");
            AboutBtn.ForeColor = Color.FromArgb(75, 75, 75);
            AboutBtn.HoverState.FillColor = Color.FromArgb(241, 241, 241);
            AboutBtn.Image = (Image)resources.GetObject("AboutBtn.Image");
            AboutBtn.ImageAlign = HorizontalAlignment.Left;
            AboutBtn.ImageSize = new Size(45, 45);
            AboutBtn.Name = "AboutBtn";
            AboutBtn.PressedColor = Color.DarkGray;
            AboutBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            AboutBtn.Click += AboutBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.Animated = true;
            HomeBtn.BackColor = Color.White;
            HomeBtn.Cursor = Cursors.Hand;
            HomeBtn.CustomizableEdges = customizableEdges5;
            HomeBtn.DisabledState.BorderColor = Color.DarkGray;
            HomeBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            HomeBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            HomeBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            HomeBtn.FillColor = Color.White;
            resources.ApplyResources(HomeBtn, "HomeBtn");
            HomeBtn.ForeColor = Color.FromArgb(75, 75, 75);
            HomeBtn.HoverState.FillColor = Color.FromArgb(241, 241, 241);
            HomeBtn.Image = (Image)resources.GetObject("HomeBtn.Image");
            HomeBtn.ImageAlign = HorizontalAlignment.Left;
            HomeBtn.ImageSize = new Size(45, 45);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.PressedColor = Color.DarkGray;
            HomeBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.White;
            SidebarPanel.Controls.Add(HomePanel);
            SidebarPanel.Controls.Add(SettingsPanel);
            SidebarPanel.Controls.Add(AboutPanel);
            resources.ApplyResources(SidebarPanel, "SidebarPanel");
            SidebarPanel.Name = "SidebarPanel";
            // 
            // HomePanel
            // 
            HomePanel.Controls.Add(HomeBtn);
            HomePanel.Controls.Add(LeftPanel1);
            resources.ApplyResources(HomePanel, "HomePanel");
            HomePanel.Name = "HomePanel";
            // 
            // LeftPanel1
            // 
            LeftPanel1.BackColor = SystemColors.ActiveCaption;
            resources.ApplyResources(LeftPanel1, "LeftPanel1");
            LeftPanel1.Name = "LeftPanel1";
            // 
            // SettingsPanel
            // 
            SettingsPanel.Controls.Add(SettingsBtn);
            SettingsPanel.Controls.Add(LeftPanel2);
            resources.ApplyResources(SettingsPanel, "SettingsPanel");
            SettingsPanel.Name = "SettingsPanel";
            // 
            // LeftPanel2
            // 
            LeftPanel2.BackColor = SystemColors.ActiveCaption;
            resources.ApplyResources(LeftPanel2, "LeftPanel2");
            LeftPanel2.Name = "LeftPanel2";
            // 
            // AboutPanel
            // 
            AboutPanel.Controls.Add(AboutBtn);
            AboutPanel.Controls.Add(LeftPanel3);
            resources.ApplyResources(AboutPanel, "AboutPanel");
            AboutPanel.Name = "AboutPanel";
            // 
            // LeftPanel3
            // 
            LeftPanel3.BackColor = SystemColors.ActiveCaption;
            resources.ApplyResources(LeftPanel3, "LeftPanel3");
            LeftPanel3.Name = "LeftPanel3";
            // 
            // MainContent
            // 
            resources.ApplyResources(MainContent, "MainContent");
            MainContent.Name = "MainContent";
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(notifyIcon1, "notifyIcon1");
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(MainContent);
            Controls.Add(SidebarPanel);
            Name = "MainForm";
            Load += MainForm_Load;
            SidebarPanel.ResumeLayout(false);
            HomePanel.ResumeLayout(false);
            SettingsPanel.ResumeLayout(false);
            AboutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel SidebarPanel;
        private Panel MainContent;
        private Guna.UI2.WinForms.Guna2Button HomeBtn;
        private Guna.UI2.WinForms.Guna2Button SettingsBtn;
        private Guna.UI2.WinForms.Guna2Button AboutBtn;
        private Panel LeftPanel1;
        private Panel LeftPanel2;
        private Panel LeftPanel3;
        private Panel HomePanel;
        private Panel SettingsPanel;
        private Panel AboutPanel;
        private NotifyIcon notifyIcon1;
    }
}
