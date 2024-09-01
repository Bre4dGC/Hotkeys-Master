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
            Notify = new NotifyIcon(components);
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            закрытьToolStripMenuItem = new ToolStripMenuItem();
            Content = new Panel();
            SidebarPanel.SuspendLayout();
            HomePanel.SuspendLayout();
            SettingsPanel.SuspendLayout();
            AboutPanel.SuspendLayout();
            guna2ContextMenuStrip1.SuspendLayout();
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
            SettingsBtn.Font = new Font("Source Sans Pro Semibold", 15.75F, FontStyle.Bold);
            SettingsBtn.ForeColor = Color.FromArgb(80, 80, 80);
            SettingsBtn.HoverState.FillColor = Color.FromArgb(241, 241, 241);
            SettingsBtn.Image = (Image)resources.GetObject("SettingsBtn.Image");
            SettingsBtn.ImageAlign = HorizontalAlignment.Left;
            SettingsBtn.ImageSize = new Size(45, 45);
            SettingsBtn.Location = new Point(5, 0);
            SettingsBtn.Margin = new Padding(0);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.PressedColor = Color.DarkGray;
            SettingsBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SettingsBtn.ShadowDecoration.Shadow = new Padding(0);
            SettingsBtn.Size = new Size(245, 90);
            SettingsBtn.TabIndex = 1;
            SettingsBtn.Text = "Settings";
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
            AboutBtn.Font = new Font("Source Sans Pro Semibold", 15.75F, FontStyle.Bold);
            AboutBtn.ForeColor = Color.FromArgb(80, 80, 80);
            AboutBtn.HoverState.FillColor = Color.FromArgb(241, 241, 241);
            AboutBtn.Image = (Image)resources.GetObject("AboutBtn.Image");
            AboutBtn.ImageAlign = HorizontalAlignment.Left;
            AboutBtn.ImageSize = new Size(45, 45);
            AboutBtn.Location = new Point(5, 0);
            AboutBtn.Margin = new Padding(0);
            AboutBtn.Name = "AboutBtn";
            AboutBtn.PressedColor = Color.DarkGray;
            AboutBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            AboutBtn.ShadowDecoration.Shadow = new Padding(0);
            AboutBtn.Size = new Size(245, 90);
            AboutBtn.TabIndex = 2;
            AboutBtn.Text = "About";
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
            HomeBtn.Font = new Font("Source Sans Pro Semibold", 15.75F, FontStyle.Bold);
            HomeBtn.ForeColor = Color.FromArgb(80, 80, 80);
            HomeBtn.HoverState.FillColor = Color.FromArgb(241, 241, 241);
            HomeBtn.Image = (Image)resources.GetObject("HomeBtn.Image");
            HomeBtn.ImageAlign = HorizontalAlignment.Left;
            HomeBtn.ImageSize = new Size(45, 45);
            HomeBtn.Location = new Point(5, 0);
            HomeBtn.Margin = new Padding(0);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.PressedColor = Color.DarkGray;
            HomeBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            HomeBtn.ShadowDecoration.Shadow = new Padding(0);
            HomeBtn.Size = new Size(245, 90);
            HomeBtn.TabIndex = 0;
            HomeBtn.Text = "Home";
            HomeBtn.Click += HomeBtn_Click;
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.White;
            SidebarPanel.Controls.Add(HomePanel);
            SidebarPanel.Controls.Add(SettingsPanel);
            SidebarPanel.Controls.Add(AboutPanel);
            SidebarPanel.Dock = DockStyle.Left;
            SidebarPanel.Location = new Point(0, 0);
            SidebarPanel.Margin = new Padding(0);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(250, 700);
            SidebarPanel.TabIndex = 4;
            // 
            // HomePanel
            // 
            HomePanel.Controls.Add(LeftPanel1);
            HomePanel.Controls.Add(HomeBtn);
            HomePanel.Location = new Point(0, 0);
            HomePanel.Margin = new Padding(0);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(250, 90);
            HomePanel.TabIndex = 0;
            // 
            // LeftPanel1
            // 
            LeftPanel1.BackColor = SystemColors.ActiveCaption;
            LeftPanel1.Dock = DockStyle.Left;
            LeftPanel1.Location = new Point(0, 0);
            LeftPanel1.Margin = new Padding(0);
            LeftPanel1.Name = "LeftPanel1";
            LeftPanel1.Size = new Size(5, 90);
            LeftPanel1.TabIndex = 1;
            // 
            // SettingsPanel
            // 
            SettingsPanel.Controls.Add(LeftPanel2);
            SettingsPanel.Controls.Add(SettingsBtn);
            SettingsPanel.Location = new Point(0, 90);
            SettingsPanel.Margin = new Padding(0);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new Size(250, 90);
            SettingsPanel.TabIndex = 2;
            // 
            // LeftPanel2
            // 
            LeftPanel2.BackColor = SystemColors.ActiveCaption;
            LeftPanel2.Dock = DockStyle.Left;
            LeftPanel2.Location = new Point(0, 0);
            LeftPanel2.Margin = new Padding(0);
            LeftPanel2.Name = "LeftPanel2";
            LeftPanel2.Size = new Size(5, 90);
            LeftPanel2.TabIndex = 2;
            LeftPanel2.Visible = false;
            // 
            // AboutPanel
            // 
            AboutPanel.Controls.Add(LeftPanel3);
            AboutPanel.Controls.Add(AboutBtn);
            AboutPanel.Location = new Point(0, 180);
            AboutPanel.Margin = new Padding(0);
            AboutPanel.Name = "AboutPanel";
            AboutPanel.Size = new Size(250, 90);
            AboutPanel.TabIndex = 2;
            // 
            // LeftPanel3
            // 
            LeftPanel3.BackColor = SystemColors.ActiveCaption;
            LeftPanel3.Dock = DockStyle.Left;
            LeftPanel3.Location = new Point(0, 0);
            LeftPanel3.Margin = new Padding(0);
            LeftPanel3.Name = "LeftPanel3";
            LeftPanel3.Size = new Size(5, 90);
            LeftPanel3.TabIndex = 3;
            LeftPanel3.Visible = false;
            // 
            // Notify
            // 
            Notify.BalloonTipIcon = ToolTipIcon.Info;
            Notify.BalloonTipText = "Ваше приложение было свернуто в трей";
            Notify.BalloonTipTitle = "Hotkey Master";
            Notify.ContextMenuStrip = guna2ContextMenuStrip1;
            Notify.Icon = (Icon)resources.GetObject("Notify.Icon");
            Notify.Visible = true;
            Notify.MouseDoubleClick += Notify_MouseDoubleClick;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, закрытьToolStripMenuItem });
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(122, 48);
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(121, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // закрытьToolStripMenuItem
            // 
            закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            закрытьToolStripMenuItem.Size = new Size(121, 22);
            закрытьToolStripMenuItem.Text = "Закрыть";
            закрытьToolStripMenuItem.Click += закрытьToolStripMenuItem_Click;
            // 
            // Content
            // 
            Content.BackColor = SystemColors.Control;
            Content.Dock = DockStyle.Fill;
            Content.Location = new Point(250, 0);
            Content.Margin = new Padding(0);
            Content.Name = "Content";
            Content.Size = new Size(950, 700);
            Content.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1200, 700);
            Controls.Add(Content);
            Controls.Add(SidebarPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HotKeys Master";
            FormClosing += MainForm_FormClosing;
            SidebarPanel.ResumeLayout(false);
            HomePanel.ResumeLayout(false);
            SettingsPanel.ResumeLayout(false);
            AboutPanel.ResumeLayout(false);
            guna2ContextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel SidebarPanel;
        private Guna.UI2.WinForms.Guna2Button HomeBtn;
        private Guna.UI2.WinForms.Guna2Button SettingsBtn;
        private Guna.UI2.WinForms.Guna2Button AboutBtn;
        private Panel LeftPanel1;
        private Panel LeftPanel2;
        private Panel LeftPanel3;
        private Panel HomePanel;
        private Panel SettingsPanel;
        private Panel AboutPanel;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem закрытьToolStripMenuItem;
        private NotifyIcon Notify;
        public static Panel Content;
    }
}
