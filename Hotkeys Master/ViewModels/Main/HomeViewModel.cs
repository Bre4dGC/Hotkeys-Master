using CommunityToolkit.Mvvm.Input;
using Hotkeys_Master.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Hotkeys_Master.ViewModels.Main
{
    class HomeViewModel : BaseViewModel
    {
        public Hotkey Hotkey { get; set; }
        public ObservableCollection<Hotkey> Hotkeys { get; }

        public ICommand AddHotkeyCommand { get; }
        public ICommand EditHotkeyCommand { get; }
        public ICommand RemoveHotkeyCommand { get; }

        public HomeViewModel()
        {
            Hotkeys = new ObservableCollection<Hotkey>();

            AddHotkeyCommand = new RelayCommand(AddHotkey);
            EditHotkeyCommand = new RelayCommand(EditHotkey);
            RemoveHotkeyCommand = new RelayCommand(RemoveHotkey);

            LoadHotkeys();
        }

        private void AddHotkey()
        {

        }

        private void EditHotkey()
        {

        }

        private void RemoveHotkey()
        {

        }

        private void LoadHotkeys()
        {

        }
	}
}
