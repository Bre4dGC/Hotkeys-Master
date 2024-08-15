namespace HotKeys_Master.CreateForm_Controllers
{
    partial class UC_CreateHotkey
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
            label = new Label();
            Hotkeys_label = new Label();
            PressEnter_label = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.Location = new Point(75, 205);
            label.Margin = new Padding(0);
            label.Name = "label";
            label.Size = new Size(435, 45);
            label.TabIndex = 3;
            label.Text = "Нажмите сочетание клавиш";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Hotkeys_label
            // 
            Hotkeys_label.AutoSize = true;
            Hotkeys_label.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Hotkeys_label.ForeColor = Color.FromArgb(68, 88, 112);
            Hotkeys_label.Location = new Point(155, 205);
            Hotkeys_label.Margin = new Padding(0);
            Hotkeys_label.Name = "Hotkeys_label";
            Hotkeys_label.Size = new Size(0, 47);
            Hotkeys_label.TabIndex = 5;
            Hotkeys_label.TextAlign = ContentAlignment.MiddleCenter;
            Hotkeys_label.Visible = false;
            // 
            // label1
            // 
            PressEnter_label.AutoSize = true;
            PressEnter_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PressEnter_label.Location = new Point(90, 115);
            PressEnter_label.Margin = new Padding(0);
            PressEnter_label.Name = "label1";
            PressEnter_label.Size = new Size(395, 32);
            PressEnter_label.TabIndex = 6;
            PressEnter_label.Text = "Чтобы продолжить нажмите Enter";
            PressEnter_label.TextAlign = ContentAlignment.MiddleCenter;
            PressEnter_label.Visible = false;
            // 
            // CreateHotkey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(PressEnter_label);
            Controls.Add(Hotkeys_label);
            Controls.Add(label);
            Margin = new Padding(0);
            Name = "CreateHotkey";
            Size = new Size(580, 420);
            KeyDown += CreateHotkey_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label Hotkeys_label;
        private Label PressEnter_label;
    }
}
