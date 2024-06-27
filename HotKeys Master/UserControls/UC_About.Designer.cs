namespace HotKeys_Master.UserControls
{
    partial class UC_About
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
            SettingsPanel1 = new Panel();
            Version = new Label();
            label1 = new Label();
            SettingsPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SettingsPanel1
            // 
            SettingsPanel1.BackColor = Color.White;
            SettingsPanel1.Controls.Add(Version);
            SettingsPanel1.Controls.Add(label1);
            SettingsPanel1.Location = new Point(20, 10);
            SettingsPanel1.Margin = new Padding(0);
            SettingsPanel1.Name = "SettingsPanel1";
            SettingsPanel1.Size = new Size(400, 90);
            SettingsPanel1.TabIndex = 3;
            // 
            // Version
            // 
            Version.AutoSize = true;
            Version.Font = new Font("Source Sans Pro Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Version.ForeColor = Color.Gray;
            Version.Location = new Point(332, 37);
            Version.Margin = new Padding(0);
            Version.Name = "Version";
            Version.Size = new Size(41, 20);
            Version.TabIndex = 2;
            Version.Text = "Beta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Sans Pro Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(75, 75, 75);
            label1.Location = new Point(21, 35);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(71, 24);
            label1.TabIndex = 1;
            label1.Text = "Version";
            // 
            // UC_About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SettingsPanel1);
            Name = "UC_About";
            Size = new Size(950, 670);
            SettingsPanel1.ResumeLayout(false);
            SettingsPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SettingsPanel1;
        private Label label1;
        private Label Version;
    }
}
