namespace HotKeys_Master.Models
{
    class Hotkey
    {
        public Keys FirstKey;
        public Keys SecondKey;
        public Keys LastKey;

        public Hotkey(Keys firstKey, Keys secondKey, Keys lastKey)
        {
            FirstKey = firstKey;
            SecondKey = secondKey;
            LastKey = lastKey;
        }
    }
}
