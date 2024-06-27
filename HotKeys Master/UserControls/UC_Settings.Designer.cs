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
            SettingsPanel1 = new Panel();
            label1 = new Label();
            ThemeSwitcher = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            SettingsPanel2 = new Panel();
            label2 = new Label();
            StartupSwitcher = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            SettingsPanel3 = new Panel();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            label3 = new Label();
            SettingsPanel1.SuspendLayout();
            SettingsPanel2.SuspendLayout();
            SettingsPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // SettingsPanel1
            // 
            SettingsPanel1.BackColor = Color.White;
            SettingsPanel1.Controls.Add(label1);
            SettingsPanel1.Controls.Add(ThemeSwitcher);
            SettingsPanel1.Location = new Point(20, 10);
            SettingsPanel1.Margin = new Padding(0);
            SettingsPanel1.Name = "SettingsPanel1";
            SettingsPanel1.Size = new Size(400, 90);
            SettingsPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Sans Pro Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(75, 75, 75);
            label1.Location = new Point(21, 35);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(110, 24);
            label1.TabIndex = 1;
            label1.Text = "Dark Theme";
            // 
            // ThemeSwitcher
            // 
            ThemeSwitcher.Animated = true;
            ThemeSwitcher.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            ThemeSwitcher.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            ThemeSwitcher.CheckedState.InnerBorderColor = Color.White;
            ThemeSwitcher.CheckedState.InnerColor = Color.White;
            ThemeSwitcher.Cursor = Cursors.Hand;
            ThemeSwitcher.CustomizableEdges = customizableEdges1;
            ThemeSwitcher.Location = new Point(321, 35);
            ThemeSwitcher.Margin = new Padding(0);
            ThemeSwitcher.Name = "ThemeSwitcher";
            ThemeSwitcher.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ThemeSwitcher.Size = new Size(52, 22);
            ThemeSwitcher.TabIndex = 0;
            ThemeSwitcher.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            ThemeSwitcher.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            ThemeSwitcher.UncheckedState.InnerBorderColor = Color.White;
            ThemeSwitcher.UncheckedState.InnerColor = Color.White;
            // 
            // SettingsPanel2
            // 
            SettingsPanel2.BackColor = Color.White;
            SettingsPanel2.Controls.Add(label2);
            SettingsPanel2.Controls.Add(StartupSwitcher);
            SettingsPanel2.Location = new Point(20, 102);
            SettingsPanel2.Margin = new Padding(0);
            SettingsPanel2.Name = "SettingsPanel2";
            SettingsPanel2.Size = new Size(400, 90);
            SettingsPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Sans Pro Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(75, 75, 75);
            label2.Location = new Point(21, 35);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(159, 24);
            label2.TabIndex = 2;
            label2.Text = "Launch at Startup";
            // 
            // StartupSwitcher
            // 
            StartupSwitcher.Animated = true;
            StartupSwitcher.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            StartupSwitcher.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            StartupSwitcher.CheckedState.InnerBorderColor = Color.White;
            StartupSwitcher.CheckedState.InnerColor = Color.White;
            StartupSwitcher.Cursor = Cursors.Hand;
            StartupSwitcher.CustomizableEdges = customizableEdges3;
            StartupSwitcher.Location = new Point(321, 37);
            StartupSwitcher.Margin = new Padding(0);
            StartupSwitcher.Name = "StartupSwitcher";
            StartupSwitcher.ShadowDecoration.CustomizableEdges = customizableEdges4;
            StartupSwitcher.Size = new Size(52, 22);
            StartupSwitcher.TabIndex = 1;
            StartupSwitcher.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            StartupSwitcher.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            StartupSwitcher.UncheckedState.InnerBorderColor = Color.White;
            StartupSwitcher.UncheckedState.InnerColor = Color.White;
            // 
            // SettingsPanel3
            // 
            SettingsPanel3.BackColor = Color.White;
            SettingsPanel3.Controls.Add(guna2ComboBox1);
            SettingsPanel3.Controls.Add(label3);
            SettingsPanel3.Location = new Point(20, 194);
            SettingsPanel3.Margin = new Padding(0);
            SettingsPanel3.Name = "SettingsPanel3";
            SettingsPanel3.Size = new Size(400, 90);
            SettingsPanel3.TabIndex = 1;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.Cursor = Cursors.Hand;
            guna2ComboBox1.CustomizableEdges = customizableEdges5;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F);
            guna2ComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Items.AddRange(new object[] { "English", "Русский" });
            guna2ComboBox1.Location = new Point(260, 30);
            guna2ComboBox1.Margin = new Padding(0);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ComboBox1.Size = new Size(113, 36);
            guna2ComboBox1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Source Sans Pro Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(75, 75, 75);
            label3.Location = new Point(21, 34);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(91, 24);
            label3.TabIndex = 3;
            label3.Text = "Language";
            // 
            // UC_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SettingsPanel1);
            Controls.Add(SettingsPanel2);
            Controls.Add(SettingsPanel3);
            Name = "UC_Settings";
            Size = new Size(950, 670);
            SettingsPanel1.ResumeLayout(false);
            SettingsPanel1.PerformLayout();
            SettingsPanel2.ResumeLayout(false);
            SettingsPanel2.PerformLayout();
            SettingsPanel3.ResumeLayout(false);
            SettingsPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel SettingsPanel2;
        private Panel SettingsPanel3;
        private Panel SettingsPanel1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ThemeSwitcher;
        private Guna.UI2.WinForms.Guna2ToggleSwitch StartupSwitcher;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Label label3;
    }
}
