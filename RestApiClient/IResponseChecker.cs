using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiClient
{
    /// <summary>
    /// Implement interface to check a response message.
    /// </summary>
    public interface IResponseChecker
    {
        /// <summary>
        /// Check response message is a corectly. 
        /// </summary>
        /// <param name="response">Response message</param>
        /// <returns>True when response is ok, else return false.</returns>
        public bool CheckResponseIsOk(string response);
    }
}
