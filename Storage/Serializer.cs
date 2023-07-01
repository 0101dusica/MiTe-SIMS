using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MiTe.Storage
{
    public class Serializer<T>
    {
        public Serializer() { }

        public void ToJSON(string fileName, List<T> objects)
        {
            var settings = GetJsonSerializerSettings();
            string json = JsonConvert.SerializeObject(objects, Formatting.Indented, settings);
            File.WriteAllText(fileName, json);
        }

        public List<T> FromJSON(string fileName)
        {
            var settings = GetJsonSerializerSettings();
            string jsonString = File.ReadAllText(fileName);
            List<T> objects = JsonConvert.DeserializeObject<List<T>>(jsonString, settings);
            return objects;
        }

        private JsonSerializerSettings GetJsonSerializerSettings()
        {
            var settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            };

            // Add converters for DateTime, DateOnly, and TimeOnly types
            var converters = new List<JsonConverter>
            {
                new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-ddTHH:mm:ss" }, // DateTime
                new DateOnlyConverter(), // DateOnly
                new TimeOnlyConverter() // TimeOnly
            };
            settings.Converters = settings.Converters.Concat(converters).ToList();

            return settings;
        }

    }

    public class DateOnlyConverter : JsonConverter<DateOnly>
    {
        public override DateOnly ReadJson(JsonReader reader, Type objectType, DateOnly existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
                return DateOnly.MinValue;

            if (DateTime.TryParse(reader.Value.ToString(), out DateTime dateTime))
                return new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);

            throw new JsonSerializationException($"Unable to parse {reader.Value} as a valid DateOnly value.");
        }

        public override void WriteJson(JsonWriter writer, DateOnly value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString("yyyy-MM-dd"));
        }
    }
    public class TimeOnlyConverter : JsonConverter<TimeOnly>
    {
        public override TimeOnly ReadJson(JsonReader reader, Type objectType, TimeOnly existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
                return TimeOnly.MinValue;

            if (TimeSpan.TryParse(reader.Value.ToString(), out TimeSpan timeSpan))
                return new TimeOnly(timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);

            throw new JsonSerializationException($"Unable to parse {reader.Value} as a valid TimeOnly value.");
        }

        public override void WriteJson(JsonWriter writer, TimeOnly value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }
    }
}
