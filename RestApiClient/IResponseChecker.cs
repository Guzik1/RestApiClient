using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiClient
{
    public interface IResponseChecker
    {
        public bool CheckResponseIsOk(string response);
    }
}
