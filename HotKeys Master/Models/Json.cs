using System.Text.Json;

namespace HotKeys_Master.Models
{
    class Json
    {
        public static void SerializeObject(object serializeObject, string fileName)
        {
            File.WriteAllText(fileName, JsonSerializer.Serialize(serializeObject));
        }

        public static T DeserializeObject<T>(out T deserializeObject, string fileName)
        {
            return deserializeObject = JsonSerializer.Deserialize<T>(File.ReadAllText(fileName));
        }
    }
}
