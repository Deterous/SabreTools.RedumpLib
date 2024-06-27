using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SabreTools.RedumpLib.Data;

namespace SabreTools.RedumpLib.Converters
{
    /// <summary>
    /// Serialize DiscCategory enum values
    /// </summary>
    public class DiscCategoryConverter : JsonConverter<DiscCategory?>
    {
        public override bool CanRead { get { return false; } }

        public override DiscCategory? ReadJson(JsonReader reader, Type objectType, DiscCategory? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, DiscCategory? value, JsonSerializer serializer)
        {
            JToken t = JToken.FromObject(value.LongName() ?? string.Empty);
            t.WriteTo(writer);
        }
    }
}