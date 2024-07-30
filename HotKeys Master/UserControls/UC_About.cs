using HotKeys_Master.Models;

namespace HotKeys_Master.UserControls
{
    public partial class UC_About : UserControl
    {
        private AboutSettings _aboutSettings = new AboutSettings();

        private const string _jsonFileName = "AboutSettings.json";

        public UC_About()
        {
            InitializeComponent();

            try
            {
                DeserializeAboutSettings();
            }
            catch
            {
                File.Delete(_jsonFileName);
            }
        }
        class AboutSettings
        {
            public int TrackBallValue { get; set; }
            public float StarRatingValue { get; set; }
        }

        private void DeserializeAboutSettings()
        {
            var trackBallValue = Json.DeserializeObject(out _aboutSettings, _jsonFileName).TrackBallValue;
            var starRatingValue = Json.DeserializeObject(out _aboutSettings, _jsonFileName).StarRatingValue;

            guna2TrackBar1.Value = trackBallValue;
            guna2RatingStar1.Value = starRatingValue;
        }


        private void TrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            _aboutSettings.TrackBallValue = guna2TrackBar1.Value;
            Json.SerializeObject(_aboutSettings, _jsonFileName);
        }

        private void RatingStar_ValueChanged(object sender, EventArgs e)
        {
            _aboutSettings.StarRatingValue = guna2RatingStar1.Value;
            Json.SerializeObject(_aboutSettings, _jsonFileName);
        }
    }
}
