using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiClient
{
    internal static class Deserialize
    {
        internal static T FromJson<T>(string jsonString)
        {
            return JsonConvert.DeserializeObject<T>(jsonString, GenerateSettings());
        }

        internal static dynamic FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject(jsonString, GenerateSettings());
        }

        internal static JsonSerializerSettings GenerateSettings()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            settings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());

            return settings;
        }
    }
}
