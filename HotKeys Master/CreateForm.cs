using HotKeys_Master.CreateForm_Controllers;
using HotKeys_Master.Models;

namespace HotKeys_Master
{
    public partial class CreateForm : Form
    {
        UC_CreateHotkey CreateHotkey = new UC_CreateHotkey();

        public CreateForm()
        {
            InitializeComponent();

            UserController.Add(Create_panel, CreateHotkey);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            Create_panel = new Guna.UI2.WinForms.Guna2Panel();
            SuspendLayout();
            // 
            // BorderlessForm
            // 
            BorderlessForm.BorderRadius = 20;
            BorderlessForm.ContainerControl = this;
            BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            BorderlessForm.DragForm = false;
            BorderlessForm.DragStartTransparencyValue = 1D;
            BorderlessForm.HasFormShadow = false;
            BorderlessForm.ResizeForm = false;
            BorderlessForm.ShadowColor = Color.DimGray;
            BorderlessForm.TransparentWhileDrag = true;
            // 
            // Create_panel
            // 
            Create_panel.CustomizableEdges = customizableEdges1;
            Create_panel.Dock = DockStyle.Fill;
            Create_panel.Location = new Point(0, 0);
            Create_panel.Margin = new Padding(0);
            Create_panel.Name = "Create_panel";
            Create_panel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Create_panel.Size = new Size(580, 420);
            Create_panel.TabIndex = 4;
            // 
            // CreateForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(580, 420);
            Controls.Add(Create_panel);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "CreateForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            KeyDown += CreateForm_KeyDown;
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        public static Guna.UI2.WinForms.Guna2Panel Create_panel;
        private System.ComponentModel.IContainer components;

        private void CreateForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
