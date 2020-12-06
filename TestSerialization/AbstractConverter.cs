using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestSerialization
{
    public class AbstractConverter<TReal, TAbstract> //: JsonConverter where TReal : TAbstract
    {
        /*
        public override Boolean CanConvert(Type objectType)
            => objectType == typeof(TAbstract);

        public override Object ReadJson()

        
        public override Object ReadJson(ref Utf8JsonReader reader, Type type)
            => JsonSerializer.Deserialize<TReal>(reader);

        public override void WriteJson(JsonWriter writer, Object value, JsonSerializer jser)
            => jser.Serialize(writer, value);
        */
    }
}
