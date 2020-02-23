using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiClient.Exception
{
    public class RestApplicationException: System.Exception
    {
        public RestApplicationException() : base() { }

        public RestApplicationException(string message) : base(message) { }

        public RestApplicationException(string message, System.Exception inner) : base(message, inner) { }
    }
}
