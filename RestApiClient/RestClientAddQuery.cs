using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Web;

namespace RestApiClient
{
    public partial class RestClient
    {
        /// <summary>
        /// Add params to url addres.
        /// </summary>
        /// <param name="queryObject">key param name, value param value.</param>
        public void AddQuery(Dictionary<string, string> queryObject)
        {
            UriBuilder builder = new UriBuilder(apiUri);
            NameValueCollection query = HttpUtility.ParseQueryString(builder.Query);

            foreach (KeyValuePair<string, string> param in queryObject)
                query[param.Key] = param.Value;

            builder.Query = query.ToString();
            apiUri = builder.ToString();
        }

        /// <summary>
        /// Add to url "?query=" + serialized object.
        /// </summary>
        /// <param name="query">Object to add to url.</param>
        public void AddQuery(object query)
        {
            string queryObjectString =  Serialize.AsJson(query);

            apiUri = apiUri + "?query=" + queryObjectString;
        }
    }
}
