namespace HotKeys_Master
{
    public partial class OverlayForm : Form
    {
        public OverlayForm()
        {
            InitializeComponent();
        }

        public void ShowOverlay(Panel ownerControl)
        {
            this.Size = ownerControl.ClientSize;
            this.Location = ownerControl.PointToScreen(Point.Empty);
            this.Show(ownerControl);
            this.BringToFront();
        }
    }
}
