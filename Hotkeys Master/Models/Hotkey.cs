using System.Windows.Input;

namespace Hotkeys_Master.Models
{
    internal class Hotkey
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public ICollection<Key> Keys { get; set; }
    }
}
