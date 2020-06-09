using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Web;

namespace RestApiClient
{
    public partial class RestClient
    {
        string query = "";

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
            this.query = builder.Query;
            apiUri = builder.ToString();

            return this.query;
        }

        /// <summary>
        /// Add string to end of query in url.
        /// </summary>
        /// <param name="query">String to add to end of query.</param>
        /// <param name="connectChar">Connection char.</param>
        /// <returns>All query params string.</returns>
        public string AddStringToEndOfQuery(string query, char connectChar = '&')
        {
            try
            {
                UriBuilder builder = new UriBuilder(apiUri);
                NameValueCollection queryValues = HttpUtility.ParseQueryString(builder.Query);

                builder.Query = queryValues.ToString();
                apiUri = builder.ToString() + query;
                this.query = builder.Query;

                return queryValues.ToString() + query;
            }
            catch (Exception)
            {
                this.query = this.query + query;
                apiUri = apiUri + query;
                return this.query;
            }
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
