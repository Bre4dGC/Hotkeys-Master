namespace HotKeys_Master.CreateForm_Controllers
{
    partial class UC_AddHotkeyPath
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            UrlPath_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            Create_btn = new Guna.UI2.WinForms.Guna2Button();
            Check_btn = new Guna.UI2.WinForms.Guna2Button();
            combobox = new Guna.UI2.WinForms.Guna2ComboBox();
            DragDrop_panel = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            DragDrop_panel.SuspendLayout();
            SuspendLayout();
            // 
            // UrlPath_textbox
            // 
            UrlPath_textbox.Animated = true;
            UrlPath_textbox.BorderRadius = 5;
            customizableEdges1.BottomRight = false;
            customizableEdges1.TopRight = false;
            UrlPath_textbox.CustomizableEdges = customizableEdges1;
            UrlPath_textbox.DefaultText = "";
            UrlPath_textbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            UrlPath_textbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            UrlPath_textbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            UrlPath_textbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            UrlPath_textbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            UrlPath_textbox.Font = new Font("Segoe UI", 9F);
            UrlPath_textbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            UrlPath_textbox.Location = new Point(73, 208);
            UrlPath_textbox.Margin = new Padding(0);
            UrlPath_textbox.MaxLength = 128;
            UrlPath_textbox.Name = "UrlPath_textbox";
            UrlPath_textbox.PasswordChar = '\0';
            UrlPath_textbox.PlaceholderText = "";
            UrlPath_textbox.SelectedText = "";
            UrlPath_textbox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            UrlPath_textbox.Size = new Size(268, 36);
            UrlPath_textbox.TabIndex = 0;
            UrlPath_textbox.Visible = false;
            UrlPath_textbox.TextChanged += UrlPath_textbox_TextChanged;
            // 
            // Create_btn
            // 
            Create_btn.AllowDrop = true;
            Create_btn.Animated = true;
            Create_btn.BorderRadius = 5;
            Create_btn.CustomizableEdges = customizableEdges3;
            Create_btn.DisabledState.BorderColor = Color.DarkGray;
            Create_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Create_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Create_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Create_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Create_btn.ForeColor = Color.White;
            Create_btn.Location = new Point(200, 340);
            Create_btn.Margin = new Padding(0);
            Create_btn.Name = "Create_btn";
            Create_btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Create_btn.Size = new Size(180, 45);
            Create_btn.TabIndex = 2;
            Create_btn.Text = "Создать";
            Create_btn.Click += Create_btn_Click;
            // 
            // Check_btn
            // 
            Check_btn.Animated = true;
            Check_btn.BorderRadius = 5;
            customizableEdges5.BottomLeft = false;
            customizableEdges5.TopLeft = false;
            Check_btn.CustomizableEdges = customizableEdges5;
            Check_btn.DisabledState.BorderColor = Color.DarkGray;
            Check_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Check_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Check_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Check_btn.Enabled = false;
            Check_btn.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Check_btn.ForeColor = Color.White;
            Check_btn.Location = new Point(341, 208);
            Check_btn.Margin = new Padding(0);
            Check_btn.Name = "Check_btn";
            Check_btn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Check_btn.Size = new Size(87, 36);
            Check_btn.TabIndex = 3;
            Check_btn.Text = "Проверить";
            Check_btn.Visible = false;
            Check_btn.Click += Check_btn_Click;
            // 
            // combobox
            // 
            combobox.BackColor = Color.Transparent;
            combobox.BorderRadius = 3;
            combobox.CustomizableEdges = customizableEdges7;
            combobox.DrawMode = DrawMode.OwnerDrawFixed;
            combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox.FocusedColor = Color.FromArgb(94, 148, 255);
            combobox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            combobox.Font = new Font("Segoe UI", 10F);
            combobox.ForeColor = Color.FromArgb(68, 88, 112);
            combobox.ItemHeight = 30;
            combobox.Items.AddRange(new object[] { "File", "Url" });
            combobox.Location = new Point(452, 208);
            combobox.Margin = new Padding(0);
            combobox.Name = "combobox";
            combobox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            combobox.Size = new Size(84, 36);
            combobox.StartIndex = 0;
            combobox.TabIndex = 4;
            combobox.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            // 
            // DragDrop_panel
            // 
            DragDrop_panel.BackColor = Color.FromArgb(253, 253, 253);
            DragDrop_panel.BorderColor = Color.FromArgb(217, 221, 226);
            DragDrop_panel.BorderRadius = 20;
            DragDrop_panel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            DragDrop_panel.BorderThickness = 1;
            DragDrop_panel.Controls.Add(label1);
            DragDrop_panel.CustomizableEdges = customizableEdges9;
            DragDrop_panel.Location = new Point(73, 85);
            DragDrop_panel.Margin = new Padding(0);
            DragDrop_panel.Name = "DragDrop_panel";
            DragDrop_panel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            DragDrop_panel.Size = new Size(355, 240);
            DragDrop_panel.TabIndex = 5;
            DragDrop_panel.Click += guna2Panel1_Click;
            DragDrop_panel.DragDrop += guna2Panel1_DragDrop;
            DragDrop_panel.DragEnter += guna2Panel1_DragEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(115, 139, 170);
            label1.Location = new Point(25, 116);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(300, 25);
            label1.TabIndex = 0;
            label1.Text = "Перетащите или выберите файл";
            // 
            // UC_AddHotkeyPath
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Check_btn);
            Controls.Add(UrlPath_textbox);
            Controls.Add(combobox);
            Controls.Add(Create_btn);
            Controls.Add(DragDrop_panel);
            Margin = new Padding(0);
            Name = "UC_AddHotkeyPath";
            Size = new Size(580, 420);
            DragDrop_panel.ResumeLayout(false);
            DragDrop_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox UrlPath_textbox;
        private Guna.UI2.WinForms.Guna2Button Create_btn;
        private Guna.UI2.WinForms.Guna2Button Check_btn;
        private Guna.UI2.WinForms.Guna2ComboBox combobox;
        private Guna.UI2.WinForms.Guna2Panel DragDrop_panel;
        private Label label1;
    }
}
