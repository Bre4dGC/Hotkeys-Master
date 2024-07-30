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
            AddButton = new Guna.UI2.WinForms.Guna2CircleButton();
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
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(AddButton);
            Margin = new Padding(0);
            Name = "UC_Home";
            Size = new Size(950, 670);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton AddButton;
    }
}
