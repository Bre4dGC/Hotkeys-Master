using CommunityToolkit.Mvvm.Input;
using Hotkeys_Master.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Hotkeys_Master.ViewModels.Main
{
    class HistoryViewModel : BaseViewModel
    {
        public Hotkey Hotkey { get; set; }
        public ObservableCollection<Hotkey> Hotkeys { get; }

        public ICommand ClearHistoryCommand { get; }

        public HistoryViewModel(Hotkey hotkey)
        {
            Hotkey = hotkey;
            Hotkeys = new ObservableCollection<Hotkey>();

            ClearHistoryCommand = new RelayCommand(ClearHistory);
        }

        private void ClearHistory()
        {
            Hotkeys.Clear();
        }
    }
}
