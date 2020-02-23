using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiClient
{
    /// <summary>
    /// Interface, own response deserializer form string response.
    /// </summary>
    /// <typeparam name="T">Type of deserialized data.</typeparam>
    public interface IResponseDeserializer<T>
    {
        /// <summary>
        /// Deserialize a response message from string to generic object.
        /// </summary>
        /// <param name="input">string response message.</param>
        /// <returns>Object of T data.</returns>
        public T Deserialize(string input);
    }
}