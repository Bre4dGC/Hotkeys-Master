using Newtonsoft.Json;

namespace HotKeys_Master.Models
{
    internal class Hotkeys
    {
        public static List<Hotkey>? Hotkey { get; set; }

        public static void SerializeHotkeys(Hotkey hotkey)
        {
            string pathToFile = "Hotkeys.json";
            var hotkeys = new List<Hotkey>();

            if (File.Exists(pathToFile))
            {
                var existingHotkeys = JsonConvert.DeserializeObject<List<Hotkey>>(File.ReadAllText(pathToFile));

                if (existingHotkeys != null)
                {
                    hotkeys.AddRange(existingHotkeys);
                }
            }

            hotkeys.Add(hotkey);
            File.WriteAllText(pathToFile, JsonConvert.SerializeObject(hotkeys));
        }
    }
}
