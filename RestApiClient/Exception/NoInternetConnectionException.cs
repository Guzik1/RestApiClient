using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiClient.Exception
{
    [Serializable]
    public class NoInternetConnectionException: System.Exception
    {
        public NoInternetConnectionException(): base() { }

        public NoInternetConnectionException(string message) : base(message) { }

        public NoInternetConnectionException(string message, System.Exception inner): base(message, inner) { }
    }
}
