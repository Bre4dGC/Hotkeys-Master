using System.Windows.Input;

namespace Hotkeys_Master.Models
{
    internal class Hotkey
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string Path { get; set; } = string.Empty;
        public Status Status { get; set; } = Status.Created;
        public ICollection<Key> Keys { get; set; } = new List<Key>();
    }

    public enum Status
    {
        Created,
        Deleted,
        Edited
    }
}