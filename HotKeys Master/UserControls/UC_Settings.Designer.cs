namespace HotKeys_Master.UserControls
{
    partial class UC_Settings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            SettingsPanel1 = new Panel();
            SettingsLabel1 = new Label();
            ThemeSwitcher = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            SettingsPanel2 = new Panel();
            SettingsLabel2 = new Label();
            StartupSwitcher = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            SettingsPanel4 = new Panel();
            LanguagesBoxList = new Guna.UI2.WinForms.Guna2ComboBox();
            SettingsLabel4 = new Label();
            SettingsLabel3 = new Label();
            SettingsPanel3 = new Panel();
            NotificationSwitcher = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            SettingsPanel1.SuspendLayout();
            SettingsPanel2.SuspendLayout();
            SettingsPanel4.SuspendLayout();
            SettingsPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // SettingsPanel1
            // 
            SettingsPanel1.BackColor = Color.White;
            SettingsPanel1.Controls.Add(SettingsLabel1);
            SettingsPanel1.Controls.Add(ThemeSwitcher);
            SettingsPanel1.Location = new Point(20, 10);
            SettingsPanel1.Margin = new Padding(0);
            SettingsPanel1.Name = "SettingsPanel1";
            SettingsPanel1.Size = new Size(500, 90);
            SettingsPanel1.TabIndex = 1;
            // 
            // SettingsLabel1
            // 
            SettingsLabel1.Anchor = AnchorStyles.Left;
            SettingsLabel1.AutoSize = true;
            SettingsLabel1.Font = new Font("Source Sans Pro Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsLabel1.ForeColor = Color.FromArgb(68, 88, 112);
            SettingsLabel1.Location = new Point(20, 35);
            SettingsLabel1.Margin = new Padding(0);
            SettingsLabel1.Name = "SettingsLabel1";
            SettingsLabel1.Size = new Size(110, 24);
            SettingsLabel1.TabIndex = 1;
            SettingsLabel1.Text = "Dark Theme";
            // 
            // ThemeSwitcher
            // 
            ThemeSwitcher.Anchor = AnchorStyles.Right;
            ThemeSwitcher.Animated = true;
            ThemeSwitcher.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            ThemeSwitcher.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            ThemeSwitcher.CheckedState.InnerBorderColor = Color.White;
            ThemeSwitcher.CheckedState.InnerColor = Color.White;
            ThemeSwitcher.Cursor = Cursors.Hand;
            ThemeSwitcher.CustomizableEdges = customizableEdges1;
            ThemeSwitcher.Location = new Point(420, 35);
            ThemeSwitcher.Margin = new Padding(0);
            ThemeSwitcher.Name = "ThemeSwitcher";
            ThemeSwitcher.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ThemeSwitcher.Size = new Size(52, 22);
            ThemeSwitcher.TabIndex = 0;
            ThemeSwitcher.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            ThemeSwitcher.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            ThemeSwitcher.UncheckedState.InnerBorderColor = Color.White;
            ThemeSwitcher.UncheckedState.InnerColor = Color.White;
            ThemeSwitcher.CheckedChanged += ThemeSwitcher_CheckedChanged;
            // 
            // SettingsPanel2
            // 
            SettingsPanel2.BackColor = Color.White;
            SettingsPanel2.Controls.Add(SettingsLabel2);
            SettingsPanel2.Controls.Add(StartupSwitcher);
            SettingsPanel2.Location = new Point(20, 102);
            SettingsPanel2.Margin = new Padding(0);
            SettingsPanel2.Name = "SettingsPanel2";
            SettingsPanel2.Size = new Size(500, 90);
            SettingsPanel2.TabIndex = 0;
            // 
            // SettingsLabel2
            // 
            SettingsLabel2.Anchor = AnchorStyles.Left;
            SettingsLabel2.AutoSize = true;
            SettingsLabel2.Font = new Font("Source Sans Pro Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsLabel2.ForeColor = Color.FromArgb(68, 88, 112);
            SettingsLabel2.Location = new Point(20, 35);
            SettingsLabel2.Margin = new Padding(0);
            SettingsLabel2.Name = "SettingsLabel2";
            SettingsLabel2.Size = new Size(159, 24);
            SettingsLabel2.TabIndex = 2;
            SettingsLabel2.Text = "Launch at Startup";
            // 
            // StartupSwitcher
            // 
            StartupSwitcher.Anchor = AnchorStyles.Right;
            StartupSwitcher.Animated = true;
            StartupSwitcher.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            StartupSwitcher.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            StartupSwitcher.CheckedState.InnerBorderColor = Color.White;
            StartupSwitcher.CheckedState.InnerColor = Color.White;
            StartupSwitcher.Cursor = Cursors.Hand;
            StartupSwitcher.CustomizableEdges = customizableEdges3;
            StartupSwitcher.Location = new Point(420, 35);
            StartupSwitcher.Margin = new Padding(0);
            StartupSwitcher.Name = "StartupSwitcher";
            StartupSwitcher.ShadowDecoration.CustomizableEdges = customizableEdges4;
            StartupSwitcher.Size = new Size(52, 22);
            StartupSwitcher.TabIndex = 1;
            StartupSwitcher.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            StartupSwitcher.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            StartupSwitcher.UncheckedState.InnerBorderColor = Color.White;
            StartupSwitcher.UncheckedState.InnerColor = Color.White;
            StartupSwitcher.CheckedChanged += StartupSwitcher_CheckedChanged;
            // 
            // SettingsPanel4
            // 
            SettingsPanel4.BackColor = Color.White;
            SettingsPanel4.Controls.Add(LanguagesBoxList);
            SettingsPanel4.Controls.Add(SettingsLabel4);
            SettingsPanel4.Location = new Point(20, 300);
            SettingsPanel4.Margin = new Padding(0);
            SettingsPanel4.Name = "SettingsPanel4";
            SettingsPanel4.Size = new Size(500, 90);
            SettingsPanel4.TabIndex = 1;
            // 
            // LanguagesBoxList
            // 
            LanguagesBoxList.Anchor = AnchorStyles.Right;
            LanguagesBoxList.BackColor = Color.Transparent;
            LanguagesBoxList.BorderColor = Color.FromArgb(171, 181, 205);
            LanguagesBoxList.BorderRadius = 3;
            LanguagesBoxList.Cursor = Cursors.Hand;
            LanguagesBoxList.CustomizableEdges = customizableEdges5;
            LanguagesBoxList.DrawMode = DrawMode.OwnerDrawFixed;
            LanguagesBoxList.DropDownStyle = ComboBoxStyle.DropDownList;
            LanguagesBoxList.FocusedColor = Color.FromArgb(171, 181, 205);
            LanguagesBoxList.FocusedState.BorderColor = Color.FromArgb(171, 181, 205);
            LanguagesBoxList.Font = new Font("Segoe UI", 10F);
            LanguagesBoxList.ForeColor = Color.FromArgb(68, 88, 112);
            LanguagesBoxList.ItemHeight = 30;
            LanguagesBoxList.Items.AddRange(new object[] { "English", "Русский" });
            LanguagesBoxList.Location = new Point(360, 30);
            LanguagesBoxList.Margin = new Padding(0);
            LanguagesBoxList.Name = "LanguagesBoxList";
            LanguagesBoxList.ShadowDecoration.CustomizableEdges = customizableEdges6;
            LanguagesBoxList.Size = new Size(113, 36);
            LanguagesBoxList.StartIndex = 0;
            LanguagesBoxList.TabIndex = 0;
            // 
            // SettingsLabel4
            // 
            SettingsLabel4.Anchor = AnchorStyles.Left;
            SettingsLabel4.AutoSize = true;
            SettingsLabel4.Font = new Font("Source Sans Pro Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsLabel4.ForeColor = Color.FromArgb(68, 88, 112);
            SettingsLabel4.Location = new Point(21, 34);
            SettingsLabel4.Margin = new Padding(0);
            SettingsLabel4.Name = "SettingsLabel4";
            SettingsLabel4.Size = new Size(91, 24);
            SettingsLabel4.TabIndex = 3;
            SettingsLabel4.Text = "Language";
            // 
            // SettingsLabel3
            // 
            SettingsLabel3.Anchor = AnchorStyles.Left;
            SettingsLabel3.AutoSize = true;
            SettingsLabel3.Font = new Font("Source Sans Pro Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsLabel3.ForeColor = Color.FromArgb(68, 88, 112);
            SettingsLabel3.Location = new Point(20, 33);
            SettingsLabel3.Margin = new Padding(0);
            SettingsLabel3.Name = "SettingsLabel3";
            SettingsLabel3.Size = new Size(161, 24);
            SettingsLabel3.TabIndex = 2;
            SettingsLabel3.Text = "Send Notifications";
            // 
            // SettingsPanel3
            // 
            SettingsPanel3.BackColor = Color.White;
            SettingsPanel3.Controls.Add(NotificationSwitcher);
            SettingsPanel3.Controls.Add(SettingsLabel3);
            SettingsPanel3.Location = new Point(20, 194);
            SettingsPanel3.Margin = new Padding(0);
            SettingsPanel3.Name = "SettingsPanel3";
            SettingsPanel3.Size = new Size(500, 90);
            SettingsPanel3.TabIndex = 3;
            // 
            // NotificationSwitcher
            // 
            NotificationSwitcher.Anchor = AnchorStyles.Right;
            NotificationSwitcher.Animated = true;
            NotificationSwitcher.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            NotificationSwitcher.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            NotificationSwitcher.CheckedState.InnerBorderColor = Color.White;
            NotificationSwitcher.CheckedState.InnerColor = Color.White;
            NotificationSwitcher.Cursor = Cursors.Hand;
            NotificationSwitcher.CustomizableEdges = customizableEdges7;
            NotificationSwitcher.Location = new Point(420, 35);
            NotificationSwitcher.Margin = new Padding(0);
            NotificationSwitcher.Name = "NotificationSwitcher";
            NotificationSwitcher.ShadowDecoration.CustomizableEdges = customizableEdges8;
            NotificationSwitcher.Size = new Size(52, 22);
            NotificationSwitcher.TabIndex = 3;
            NotificationSwitcher.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            NotificationSwitcher.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            NotificationSwitcher.UncheckedState.InnerBorderColor = Color.White;
            NotificationSwitcher.UncheckedState.InnerColor = Color.White;
            NotificationSwitcher.CheckedChanged += NotificationSwitcher_CheckedChanged;
            // 
            // UC_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(SettingsPanel3);
            Controls.Add(SettingsPanel1);
            Controls.Add(SettingsPanel4);
            Controls.Add(SettingsPanel2);
            Location = new Point(420, 35);
            Margin = new Padding(0);
            Name = "UC_Settings";
            Size = new Size(950, 670);
            SettingsPanel1.ResumeLayout(false);
            SettingsPanel1.PerformLayout();
            SettingsPanel2.ResumeLayout(false);
            SettingsPanel2.PerformLayout();
            SettingsPanel4.ResumeLayout(false);
            SettingsPanel4.PerformLayout();
            SettingsPanel3.ResumeLayout(false);
            SettingsPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel SettingsPanel2;
        private Panel SettingsPanel4;
        private Panel SettingsPanel1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ThemeSwitcher;
        private Guna.UI2.WinForms.Guna2ToggleSwitch StartupSwitcher;
        private Label SettingsLabel1;
        private Label SettingsLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox LanguagesBoxList;
        private Label SettingsLabel4;
        private Label SettingsLabel3;
        private Panel SettingsPanel3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch NotificationSwitcher;
    }
}
