using System.Runtime.Serialization.Json;

namespace TestSerialization
{
    public static class SerializationUtil
    {
        public static string Serialize<T>(T o)
        {
            if (o == null)
            {
                return "";
            }

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));

            ser.WriteObject(ms, o);
            byte[] jsonData = ms.ToArray();

            ms.Close();
            return System.Text.Encoding.UTF8.GetString(jsonData, 0, jsonData.Length);
        }

        public static T Deserialize<T>(string json) where T : class, new()
        {
            if (json == null || json == "")
            {
                return null;
            }

            T deserialized = new T();
            System.IO.MemoryStream ms = new System.IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(deserialized.GetType());

            deserialized = ser.ReadObject(ms) as T;

            ms.Close();
            return deserialized;
        }
    }
}
