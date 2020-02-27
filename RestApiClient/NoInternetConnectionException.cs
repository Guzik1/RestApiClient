using System;

namespace RestApiClient
{
    [Serializable]
    public class NoInternetConnectionException : Exception
    {
        public NoInternetConnectionException() : base() { }

        public NoInternetConnectionException(string message) : base(message) { }

        public NoInternetConnectionException(string message, Exception inner) : base(message, inner) { }
    }
}
