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
        /// Add query params to url addres.
        /// </summary>
        /// <param name="queryObject">key param name, value param value.</param>
        /// <return>Return query string.</return>
        public string AddQuery(Dictionary<string, string> queryObject)
        {
            UriBuilder builder = new UriBuilder(apiUri);
            NameValueCollection query = HttpUtility.ParseQueryString(builder.Query);

            foreach (KeyValuePair<string, string> param in queryObject)
                query[param.Key] = param.Value;

            builder.Query = query.ToString();
            apiUri = builder.ToString();

            return query.ToString();
        }

        /// <summary>
        /// Add to url "?query=" + serialized object.
        /// </summary>
        /// <param name="query">Object to add to url.</param>
        /// <return>String of object.</return>
        public string AddQuery(object query)
        {
            string queryObjectString =  Serialize.AsJson(query);

            apiUri = apiUri + "?query=" + queryObjectString;

            return queryObjectString;
        }
    }
}
