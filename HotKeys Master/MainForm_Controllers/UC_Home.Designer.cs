namespace HotKeys_Master.UserControls
{
    partial class UC_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            AddButton = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddButton.Animated = true;
            AddButton.Cursor = Cursors.Hand;
            AddButton.DisabledState.BorderColor = Color.DarkGray;
            AddButton.DisabledState.CustomBorderColor = Color.DarkGray;
            AddButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddButton.Font = new Font("Segoe UI", 9F);
            AddButton.ForeColor = Color.White;
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.ImageSize = new Size(30, 30);
            AddButton.Location = new Point(850, 570);
            AddButton.Margin = new Padding(0);
            AddButton.Name = "AddButton";
            AddButton.ShadowDecoration.BorderRadius = 20;
            AddButton.ShadowDecoration.CustomizableEdges = customizableEdges1;
            AddButton.ShadowDecoration.Depth = 50;
            AddButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            AddButton.ShadowDecoration.Shadow = new Padding(10);
            AddButton.Size = new Size(70, 70);
            AddButton.TabIndex = 1;
            AddButton.Click += AddButton_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.BorderRadius = 10;
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges2;
            guna2Panel1.Location = new Point(23, 26);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Panel1.Size = new Size(897, 94);
            guna2Panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 37);
            label1.Name = "label1";
            label1.Size = new Size(66, 30);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel1);
            Controls.Add(AddButton);
            Margin = new Padding(0);
            Name = "UC_Home";
            Size = new Size(950, 670);
            Load += UC_Home_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton AddButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
    }
}
