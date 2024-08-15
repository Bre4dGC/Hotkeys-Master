namespace HotKeys_Master.Models.Hotkey
{
    class Hotkey
    {
        public string Name { get; set; }

        public Keys FirstKey { get; set; }
        public Keys SecondKey { get; set; }
        public Keys LastKey { get; set; }

        public Hotkey(Keys firstKey, Keys secondKey, Keys lastKey, string name)
        {
            Name = name;

            FirstKey = firstKey;
            SecondKey = secondKey;
            LastKey = lastKey;
        }
    }
}
