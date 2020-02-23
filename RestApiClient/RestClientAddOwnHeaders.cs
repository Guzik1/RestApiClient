using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiClient
{
    public partial class RestClient
    {
        IAddOwnHeaderToRequest AddHeaderMethod;

        /// <summary>
        /// Add own headert to request using interface.
        /// </summary>
        /// <param name="methodAddHeaders">method implemeted interface to add own headers.</param>
        public void AddOwnHeaderToRequest(IAddOwnHeaderToRequest methodAddHeaders)
        {
            AddHeaderMethod = methodAddHeaders;
        }

        void AddHeaderToRequest() => AddOwnHeader(AddHeaderMethod?.AddOwnHeader());

        void AddHeaderToRequestPost<T>(T dataToSend)
            => AddOwnHeader(AddHeaderMethod?.AddOwnHeaderPOST(dataToSend));

        void AddOwnHeader(Dictionary<string, string> headers)
        {
            if (headers == null)
                return;

            foreach (KeyValuePair<string, string> header in headers)
                client.DefaultRequestHeaders.Add(header.Key, header.Value);
        }
    }
}
