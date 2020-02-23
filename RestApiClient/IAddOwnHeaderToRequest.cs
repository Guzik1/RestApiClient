using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace RestApiClient
{
    /// <summary>
    /// Interface to add own header.
    /// </summary>
    public interface IAddOwnHeaderToRequest
    {
        /// <summary>
        /// Method to add own header without post request. Call before message send.
        /// </summary>
        /// <returns>Dictionary where key is header name and value is header value.</returns>
        public Dictionary<string, string> AddOwnHeader();

        /// <summary>
        /// Method to add own header to post request. Call before message send.
        /// </summary>
        /// <returns>Dictionary where key is header name and value is header value.</returns>
        public Dictionary<string, string> AddOwnHeaderPOST(object POSTDataToSend);
    }
}
