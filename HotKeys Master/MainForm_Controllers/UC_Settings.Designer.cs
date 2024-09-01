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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            SettingsPanel1 = new Panel();
            SettingsLabel1 = new Label();
            Theme_Switcher = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            SettingsPanel2 = new Panel();
            SettingsLabel2 = new Label();
            Startup_Switcher = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            SettingsPanel5 = new Panel();
            Languages_combobox = new Guna.UI2.WinForms.Guna2ComboBox();
            SettingsLabel5 = new Label();
            SettingsLabel3 = new Label();
            SettingsPanel3 = new Panel();
            Notification_Switcher = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            SettingsPanel4 = new Panel();
            HideWindow_Switcher = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            SettingsLabel4 = new Label();
            SettingsPanel1.SuspendLayout();
            SettingsPanel2.SuspendLayout();
            SettingsPanel5.SuspendLayout();
            SettingsPanel3.SuspendLayout();
            SettingsPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // SettingsPanel1
            // 
            SettingsPanel1.BackColor = Color.White;
            SettingsPanel1.Controls.Add(SettingsLabel1);
            SettingsPanel1.Controls.Add(Theme_Switcher);
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
            SettingsLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Theme_Switcher
            // 
            Theme_Switcher.Anchor = AnchorStyles.Right;
            Theme_Switcher.Animated = true;
            Theme_Switcher.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Theme_Switcher.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Theme_Switcher.CheckedState.InnerBorderColor = Color.White;
            Theme_Switcher.CheckedState.InnerColor = Color.White;
            Theme_Switcher.Cursor = Cursors.Hand;
            Theme_Switcher.CustomizableEdges = customizableEdges11;
            Theme_Switcher.Location = new Point(420, 35);
            Theme_Switcher.Margin = new Padding(0);
            Theme_Switcher.Name = "Theme_Switcher";
            Theme_Switcher.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Theme_Switcher.Size = new Size(52, 22);
            Theme_Switcher.TabIndex = 0;
            Theme_Switcher.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Theme_Switcher.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            Theme_Switcher.UncheckedState.InnerBorderColor = Color.White;
            Theme_Switcher.UncheckedState.InnerColor = Color.White;
            Theme_Switcher.CheckedChanged += ThemeSwitcher_CheckedChanged;
            // 
            // SettingsPanel2
            // 
            SettingsPanel2.BackColor = Color.White;
            SettingsPanel2.Controls.Add(SettingsLabel2);
            SettingsPanel2.Controls.Add(Startup_Switcher);
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
            // Startup_Switcher
            // 
            Startup_Switcher.Anchor = AnchorStyles.Right;
            Startup_Switcher.Animated = true;
            Startup_Switcher.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Startup_Switcher.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Startup_Switcher.CheckedState.InnerBorderColor = Color.White;
            Startup_Switcher.CheckedState.InnerColor = Color.White;
            Startup_Switcher.Cursor = Cursors.Hand;
            Startup_Switcher.CustomizableEdges = customizableEdges13;
            Startup_Switcher.Location = new Point(420, 35);
            Startup_Switcher.Margin = new Padding(0);
            Startup_Switcher.Name = "Startup_Switcher";
            Startup_Switcher.ShadowDecoration.CustomizableEdges = customizableEdges14;
            Startup_Switcher.Size = new Size(52, 22);
            Startup_Switcher.TabIndex = 1;
            Startup_Switcher.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Startup_Switcher.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            Startup_Switcher.UncheckedState.InnerBorderColor = Color.White;
            Startup_Switcher.UncheckedState.InnerColor = Color.White;
            Startup_Switcher.CheckedChanged += StartupSwitcher_CheckedChanged;
            // 
            // SettingsPanel5
            // 
            SettingsPanel5.BackColor = Color.White;
            SettingsPanel5.Controls.Add(Languages_combobox);
            SettingsPanel5.Controls.Add(SettingsLabel5);
            SettingsPanel5.Location = new Point(20, 450);
            SettingsPanel5.Margin = new Padding(0);
            SettingsPanel5.Name = "SettingsPanel5";
            SettingsPanel5.Size = new Size(500, 90);
            SettingsPanel5.TabIndex = 1;
            // 
            // Languages_combobox
            // 
            Languages_combobox.Anchor = AnchorStyles.Right;
            Languages_combobox.BackColor = Color.Transparent;
            Languages_combobox.BorderColor = Color.FromArgb(171, 181, 205);
            Languages_combobox.BorderRadius = 3;
            Languages_combobox.Cursor = Cursors.Hand;
            Languages_combobox.CustomizableEdges = customizableEdges15;
            Languages_combobox.DrawMode = DrawMode.OwnerDrawFixed;
            Languages_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            Languages_combobox.FocusedColor = Color.FromArgb(171, 181, 205);
            Languages_combobox.FocusedState.BorderColor = Color.FromArgb(171, 181, 205);
            Languages_combobox.Font = new Font("Segoe UI", 10F);
            Languages_combobox.ForeColor = Color.FromArgb(68, 88, 112);
            Languages_combobox.ItemHeight = 30;
            Languages_combobox.Items.AddRange(new object[] { "English", "Русский" });
            Languages_combobox.Location = new Point(360, 30);
            Languages_combobox.Margin = new Padding(0);
            Languages_combobox.Name = "Languages_combobox";
            Languages_combobox.ShadowDecoration.CustomizableEdges = customizableEdges16;
            Languages_combobox.Size = new Size(113, 36);
            Languages_combobox.StartIndex = 0;
            Languages_combobox.TabIndex = 0;
            // 
            // SettingsLabel5
            // 
            SettingsLabel5.Anchor = AnchorStyles.Left;
            SettingsLabel5.AutoSize = true;
            SettingsLabel5.Font = new Font("Source Sans Pro Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsLabel5.ForeColor = Color.FromArgb(68, 88, 112);
            SettingsLabel5.Location = new Point(21, 34);
            SettingsLabel5.Margin = new Padding(0);
            SettingsLabel5.Name = "SettingsLabel5";
            SettingsLabel5.Size = new Size(91, 24);
            SettingsLabel5.TabIndex = 3;
            SettingsLabel5.Text = "Language";
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
            SettingsPanel3.Controls.Add(Notification_Switcher);
            SettingsPanel3.Controls.Add(SettingsLabel3);
            SettingsPanel3.Location = new Point(20, 194);
            SettingsPanel3.Margin = new Padding(0);
            SettingsPanel3.Name = "SettingsPanel3";
            SettingsPanel3.Size = new Size(500, 90);
            SettingsPanel3.TabIndex = 3;
            // 
            // Notification_Switcher
            // 
            Notification_Switcher.Anchor = AnchorStyles.Right;
            Notification_Switcher.Animated = true;
            Notification_Switcher.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Notification_Switcher.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Notification_Switcher.CheckedState.InnerBorderColor = Color.White;
            Notification_Switcher.CheckedState.InnerColor = Color.White;
            Notification_Switcher.Cursor = Cursors.Hand;
            Notification_Switcher.CustomizableEdges = customizableEdges17;
            Notification_Switcher.Location = new Point(420, 35);
            Notification_Switcher.Margin = new Padding(0);
            Notification_Switcher.Name = "Notification_Switcher";
            Notification_Switcher.ShadowDecoration.CustomizableEdges = customizableEdges18;
            Notification_Switcher.Size = new Size(52, 22);
            Notification_Switcher.TabIndex = 3;
            Notification_Switcher.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Notification_Switcher.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            Notification_Switcher.UncheckedState.InnerBorderColor = Color.White;
            Notification_Switcher.UncheckedState.InnerColor = Color.White;
            Notification_Switcher.CheckedChanged += NotificationSwitcher_CheckedChanged;
            // 
            // SettingsPanel4
            // 
            SettingsPanel4.BackColor = Color.White;
            SettingsPanel4.Controls.Add(HideWindow_Switcher);
            SettingsPanel4.Controls.Add(SettingsLabel4);
            SettingsPanel4.Location = new Point(20, 286);
            SettingsPanel4.Margin = new Padding(0);
            SettingsPanel4.Name = "SettingsPanel4";
            SettingsPanel4.Size = new Size(500, 90);
            SettingsPanel4.TabIndex = 4;
            // 
            // HideWindow_Switcher
            // 
            HideWindow_Switcher.Anchor = AnchorStyles.Right;
            HideWindow_Switcher.Animated = true;
            HideWindow_Switcher.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            HideWindow_Switcher.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            HideWindow_Switcher.CheckedState.InnerBorderColor = Color.White;
            HideWindow_Switcher.CheckedState.InnerColor = Color.White;
            HideWindow_Switcher.Cursor = Cursors.Hand;
            HideWindow_Switcher.CustomizableEdges = customizableEdges19;
            HideWindow_Switcher.Location = new Point(420, 35);
            HideWindow_Switcher.Margin = new Padding(0);
            HideWindow_Switcher.Name = "HideWindow_Switcher";
            HideWindow_Switcher.ShadowDecoration.CustomizableEdges = customizableEdges20;
            HideWindow_Switcher.Size = new Size(52, 22);
            HideWindow_Switcher.TabIndex = 4;
            HideWindow_Switcher.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            HideWindow_Switcher.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            HideWindow_Switcher.UncheckedState.InnerBorderColor = Color.White;
            HideWindow_Switcher.UncheckedState.InnerColor = Color.White;
            HideWindow_Switcher.CheckedChanged += HideWindow_Switcher_CheckedChanged;
            // 
            // SettingsLabel4
            // 
            SettingsLabel4.Anchor = AnchorStyles.Left;
            SettingsLabel4.AutoSize = true;
            SettingsLabel4.Font = new Font("Source Sans Pro Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsLabel4.ForeColor = Color.FromArgb(68, 88, 112);
            SettingsLabel4.Location = new Point(20, 35);
            SettingsLabel4.Margin = new Padding(0);
            SettingsLabel4.Name = "SettingsLabel4";
            SettingsLabel4.Size = new Size(208, 24);
            SettingsLabel4.TabIndex = 2;
            SettingsLabel4.Text = "Hide Window on Closing";
            // 
            // UC_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(SettingsPanel4);
            Controls.Add(SettingsPanel3);
            Controls.Add(SettingsPanel1);
            Controls.Add(SettingsPanel5);
            Controls.Add(SettingsPanel2);
            Location = new Point(420, 35);
            Margin = new Padding(0);
            Name = "UC_Settings";
            Size = new Size(950, 670);
            SettingsPanel1.ResumeLayout(false);
            SettingsPanel1.PerformLayout();
            SettingsPanel2.ResumeLayout(false);
            SettingsPanel2.PerformLayout();
            SettingsPanel5.ResumeLayout(false);
            SettingsPanel5.PerformLayout();
            SettingsPanel3.ResumeLayout(false);
            SettingsPanel3.PerformLayout();
            SettingsPanel4.ResumeLayout(false);
            SettingsPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel SettingsPanel2;
        private Panel SettingsPanel5;
        private Panel SettingsPanel1;
        private Label SettingsLabel1;
        private Label SettingsLabel2;
        private Label SettingsLabel5;
        private Label SettingsLabel3;
        private Panel SettingsPanel3;
        private Panel SettingsPanel4;
        private Label SettingsLabel4;
        public static Guna.UI2.WinForms.Guna2ToggleSwitch Theme_Switcher;
        public static Guna.UI2.WinForms.Guna2ToggleSwitch Startup_Switcher;
        public static Guna.UI2.WinForms.Guna2ComboBox Languages_combobox;
        public static Guna.UI2.WinForms.Guna2ToggleSwitch Notification_Switcher;
        public static Guna.UI2.WinForms.Guna2ToggleSwitch HideWindow_Switcher;
    }
}
