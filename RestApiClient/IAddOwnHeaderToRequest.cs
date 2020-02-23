using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace RestApiClient
{
    public interface IAddOwnHeaderToRequest
    {
        public Dictionary<string, string> AddOwnHeader();
        public Dictionary<string, string> AddOwnHeaderPOST(object POSTDataToSend);
    }
}
