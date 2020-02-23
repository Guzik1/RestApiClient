using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace RestApiClient
{
    /// <summary>
    /// Checker internet connection.
    /// </summary>
    public static class InternetConnectionChecker
    {
        /// <summary>
        /// Check machine has been connected to network.
        /// </summary>
        /// <returns>True when internet connection availbale, else return false.</returns>
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
