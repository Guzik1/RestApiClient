using RestApiClient.Exception;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace RestApiClient
{
    public static class InternetConnectionChecker
    {
        public static bool Check()
        {
            try
            {
                using (WebClient client = new WebClient())
                    using (client.OpenRead("http://google.com/generate_204"))
                        return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
