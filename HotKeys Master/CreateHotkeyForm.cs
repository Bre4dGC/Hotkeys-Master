using HotKeys_Master.Models;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace HotKeys_Master
{
    public partial class CreateHotkeyForm : Form
    {
        public Keys FirstKey { get; private set; }
        public Keys SecondKey { get; private set; }
        public Keys LastKey { get; private set; }

        //это нужно чтобы в лабел выводилось не Control а Ctrl 
        private Dictionary<Keys, string> KeyNames = new Dictionary<Keys, string>
        {
            { Keys.Control, "Ctrl"}
        };

        public CreateHotkeyForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateHotkeyForm));
            BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            CloseFormBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            lblHotkey = new Label();
            CreateBtn = new Guna.UI2.WinForms.Guna2Button();
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
            // CloseFormBtn
            // 
            CloseFormBtn.Animated = true;
            CloseFormBtn.DisabledState.BorderColor = Color.DarkGray;
            CloseFormBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            CloseFormBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CloseFormBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CloseFormBtn.FillColor = SystemColors.Window;
            CloseFormBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CloseFormBtn.ForeColor = Color.Black;
            CloseFormBtn.HoverState.FillColor = Color.Red;
            CloseFormBtn.HoverState.ForeColor = Color.White;
            CloseFormBtn.Location = new Point(541, 9);
            CloseFormBtn.Margin = new Padding(0);
            CloseFormBtn.Name = "CloseFormBtn";
            CloseFormBtn.ShadowDecoration.CustomizableEdges = customizableEdges3;
            CloseFormBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            CloseFormBtn.Size = new Size(30, 30);
            CloseFormBtn.TabIndex = 0;
            CloseFormBtn.Text = "X";
            CloseFormBtn.Click += CloseFormBtn_Click;
            // 
            // lblHotkey
            // 
            lblHotkey.AutoSize = true;
            lblHotkey.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHotkey.Location = new Point(71, 190);
            lblHotkey.Margin = new Padding(0);
            lblHotkey.Name = "lblHotkey";
            lblHotkey.Size = new Size(435, 45);
            lblHotkey.TabIndex = 1;
            lblHotkey.Text = "Нажмите сочетание клавиш";
            // 
            // CreateBtn
            // 
            CreateBtn.Animated = true;
            CreateBtn.CustomizableEdges = customizableEdges1;
            CreateBtn.DisabledState.BorderColor = Color.DarkGray;
            CreateBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            CreateBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CreateBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CreateBtn.Enabled = false;
            CreateBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateBtn.ForeColor = Color.White;
            CreateBtn.Location = new Point(186, 342);
            CreateBtn.Margin = new Padding(0);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CreateBtn.Size = new Size(180, 45);
            CreateBtn.TabIndex = 2;
            CreateBtn.Text = "Создать";
            CreateBtn.Visible = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // CreateHotkeyForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(580, 420);
            Controls.Add(CreateBtn);
            Controls.Add(lblHotkey);
            Controls.Add(CloseFormBtn);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "CreateHotkeyForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += CreateHotkeyForm_Load;
            KeyDown += CreateHotkeyForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2CircleButton CloseFormBtn;
        private Label lblHotkey;
        private Guna.UI2.WinForms.Guna2Button CreateBtn;
        private System.ComponentModel.IContainer components;

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateHotkeyForm_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;

            if ((e.Control || e.Shift || e.Alt) && (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z))
            {
                FirstKey = e.Control ? Keys.Control : (e.Alt ? Keys.Alt : (e.Shift ? Keys.Shift : Keys.None));
                SecondKey = (e.Control && e.Alt) ? Keys.Alt : (e.Control && e.Shift) ? Keys.Shift : (e.Alt && e.Shift) ? Keys.Shift : Keys.None;
                LastKey = e.KeyCode;



                string keyData = (FirstKey != Keys.None ? GetKeyName(FirstKey) + " + " : "") +
                                     (SecondKey != Keys.None ? SecondKey.ToString() + " + " : "") +
                                     (LastKey != Keys.ControlKey && LastKey != Keys.Menu && LastKey != Keys.ShiftKey ? LastKey.ToString() : "");

                CreateBtn.Visible = true;

                lblHotkey.Text = keyData;
            }

            if (e.KeyCode == Keys.Escape)
            {
                CreateBtn.Enabled = true;
            }
        }

        private string GetKeyName(Keys key)
        {
            return KeyNames.ContainsKey(key) ? KeyNames[key] : key.ToString();
        }

        private void CreateHotkeyForm_Load(object sender, EventArgs e)
        {
            lblHotkey.Text = "Нажмите сочетание клавиш";
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            var hotkey = new Hotkey(FirstKey, SecondKey, LastKey);
            Hotkeys.SerializeHotkeys(hotkey);
        }
    }
}
