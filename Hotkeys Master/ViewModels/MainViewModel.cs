using CommunityToolkit.Mvvm.Input;
using Hotkeys_Master.Views.Pages;
using System.Windows.Controls;
using System.Windows.Input;

namespace Hotkeys_Master.ViewModels
{
    class MainViewModel : BaseViewModel
    {
		private Page _currentView;

		public Page CurrentView
		{
			get { return _currentView; }
			set { _currentView = value; OnPropertyChanged(); }
		}

        public ICommand HomeCommand { get; set; } 
		public ICommand HistoryCommand { get; set; }
        public ICommand SettingsCommand { get; set; } 
        public ICommand AboutCommand { get; set; }

        private void Home() => CurrentView = new HomeView();
        private void History() => CurrentView = new HistoryView();
        private void Settings() => CurrentView = new SettingsView();
        private void About() => CurrentView = new AboutView();

        public MainViewModel()
        {
            HomeCommand = new RelayCommand(Home);
            HistoryCommand = new RelayCommand(History);
            SettingsCommand = new RelayCommand(Settings);
            AboutCommand = new RelayCommand(About);

            CurrentView = CurrentView = new HomeView();
        }
    }
}
