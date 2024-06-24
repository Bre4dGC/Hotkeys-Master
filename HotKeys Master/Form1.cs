using System.Diagnostics;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using Guna.UI2.WinForms;

namespace HotKeys_Master
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        bool Dragging = false;
        Point DragCursorPoint;
        Point DragFormPoint;

        private void PanelStyleReset()
        {
            LeftPanel1.Visible = false;
            LeftPanel2.Visible = false;
            LeftPanel3.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PanelStyleReset();
            LeftPanel1.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            PanelStyleReset();
            LeftPanel2.Visible = true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            PanelStyleReset();
            LeftPanel3.Visible = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ControlPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void ControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursorPoint = Cursor.Position;
            DragFormPoint = this.Location;
        }

        private void ControlPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void ControlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursorPoint));
                this.Location = Point.Add(DragFormPoint, new Size(dif));
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Hotkey Master";
            notifyIcon1.BalloonTipText = "The application has switched to background mode";
            notifyIcon1.Text = "Hotkey Master";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }
    }
}
