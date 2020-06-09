using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace RestApiClient
{
    internal static class Serialize
    {
        internal static string AsJson(object data)
        {
            return JsonConvert.SerializeObject(data, Deserialize.GenerateSettings());
        }
    }
}
