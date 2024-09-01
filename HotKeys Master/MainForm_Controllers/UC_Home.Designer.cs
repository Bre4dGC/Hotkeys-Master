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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            AddButton = new Guna.UI2.WinForms.Guna2CircleButton();
            HotkeysList_flowpanel = new FlowLayoutPanel();
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
            AddButton.Location = new Point(858, 584);
            AddButton.Margin = new Padding(0);
            AddButton.Name = "AddButton";
            AddButton.ShadowDecoration.BorderRadius = 20;
            AddButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            AddButton.ShadowDecoration.Depth = 50;
            AddButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            AddButton.ShadowDecoration.Shadow = new Padding(10);
            AddButton.Size = new Size(70, 70);
            AddButton.TabIndex = 1;
            AddButton.Click += AddButton_Click;
            // 
            // HotkeysList_flowpanel
            // 
            HotkeysList_flowpanel.AutoScroll = true;
            HotkeysList_flowpanel.BackColor = Color.Transparent;
            HotkeysList_flowpanel.FlowDirection = FlowDirection.TopDown;
            HotkeysList_flowpanel.Location = new Point(15, 13);
            HotkeysList_flowpanel.Margin = new Padding(0);
            HotkeysList_flowpanel.Name = "HotkeysList_flowpanel";
            HotkeysList_flowpanel.Size = new Size(913, 641);
            HotkeysList_flowpanel.TabIndex = 2;
            HotkeysList_flowpanel.WrapContents = false;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(AddButton);
            Controls.Add(HotkeysList_flowpanel);
            ForeColor = Color.Transparent;
            Margin = new Padding(0);
            Name = "UC_Home";
            Size = new Size(950, 670);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton AddButton;
        private static FlowLayoutPanel HotkeysList_flowpanel;
    }
}
