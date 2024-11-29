using CommunityToolkit.Mvvm.Input;
using Hotkeys_Master.Views.Pages.Main;
using System.Windows.Controls;
using System.Windows.Input;

namespace Hotkeys_Master.ViewModels.Window
{
    class MainViewModel : BaseViewModel
    {
        private Page _currentView;

        public Page CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; }
        public ICommand HistoryCommand { get; }
        public ICommand SettingsCommand { get; }
        public ICommand AboutCommand { get; }

        public MainViewModel()
        {
            HomeCommand = new RelayCommand(() => CurrentView = new HomeView());
            HistoryCommand = new RelayCommand(() => CurrentView = new HistoryView());
            SettingsCommand = new RelayCommand(() => CurrentView = new SettingsView());
            AboutCommand = new RelayCommand(() => CurrentView = new AboutView());

            CurrentView = new HomeView();
        }
    }
}
