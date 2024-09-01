namespace HotKeys_Master.Models.Hotkey
{
    public class Hotkey
    {
        public string Title { get; set; }

        public string Path { get; set; }

        public Keys FirstKey { get; set; }
        public Keys SecondKey { get; set; }
        public Keys LastKey { get; set; }

        public Hotkey() { }

        public Hotkey(Keys firstKey, Keys secondKey, Keys lastKey)
        {
            FirstKey = firstKey;
            SecondKey = secondKey;
            LastKey = lastKey;
        }

        public Hotkey(Keys firstKey, Keys secondKey, Keys lastKey, string name, string path)
        {
            Title = name;

            Path = path;

            FirstKey = firstKey;
            SecondKey = secondKey;
            LastKey = lastKey;
        }
    }
}
