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
            AboutPanel1 = new Panel();
            Version = new Label();
            label1 = new Label();
            guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            AboutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // AboutPanel1
            // 
            AboutPanel1.BackColor = Color.White;
            AboutPanel1.Controls.Add(Version);
            AboutPanel1.Controls.Add(label1);
            AboutPanel1.Location = new Point(20, 10);
            AboutPanel1.Margin = new Padding(0);
            AboutPanel1.Name = "AboutPanel1";
            AboutPanel1.Size = new Size(500, 90);
            AboutPanel1.TabIndex = 3;
            // 
            // Version
            // 
            Version.Anchor = AnchorStyles.Right;
            Version.AutoSize = true;
            Version.Font = new Font("Source Sans Pro Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Version.ForeColor = Color.FromArgb(72, 86, 119);
            Version.Location = new Point(432, 37);
            Version.Margin = new Padding(0);
            Version.Name = "Version";
            Version.Size = new Size(41, 20);
            Version.TabIndex = 2;
            Version.Text = "Beta";
            Version.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Source Sans Pro Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(68, 88, 112);
            label1.Location = new Point(21, 35);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(71, 24);
            label1.TabIndex = 1;
            label1.Text = "Version";
            // 
            // guna2TrackBar1
            // 
            guna2TrackBar1.Location = new Point(20, 150);
            guna2TrackBar1.Name = "guna2TrackBar1";
            guna2TrackBar1.Size = new Size(300, 23);
            guna2TrackBar1.TabIndex = 4;
            guna2TrackBar1.ThumbColor = Color.FromArgb(160, 113, 255);
            guna2TrackBar1.Scroll += TrackBar_Scroll;
            // 
            // guna2RatingStar1
            // 
            guna2RatingStar1.Location = new Point(20, 198);
            guna2RatingStar1.Name = "guna2RatingStar1";
            guna2RatingStar1.RatingColor = Color.Gold;
            guna2RatingStar1.Size = new Size(300, 51);
            guna2RatingStar1.TabIndex = 5;
            guna2RatingStar1.ValueChanged += RatingStar_ValueChanged;
            // 
            // UC_About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(guna2RatingStar1);
            Controls.Add(guna2TrackBar1);
            Controls.Add(AboutPanel1);
            Margin = new Padding(0);
            Name = "UC_About";
            Size = new Size(950, 670);
            AboutPanel1.ResumeLayout(false);
            AboutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AboutPanel1;
        private Label label1;
        private Label Version;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
    }
}
