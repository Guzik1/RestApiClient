using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiClient.Exception
{
    public class UnknownCommunicationException: System.Exception
    {
        public UnknownCommunicationException() : base() { }

        public UnknownCommunicationException(string message) : base(message) { }

        public UnknownCommunicationException(string message, System.Exception inner) : base(message, inner) { }

    }
}
