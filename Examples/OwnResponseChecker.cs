using System;
using System.Collections.Generic;
using System.Text;
using RestApiClient;

namespace Examples
{
    public class OwnResponseChecker
    {
        public void Example()
        {
            string url = @"testurl.com/api";

            RestClient client = new RestClient(url);

            // Call to api:
            client.SendGET();

            Response response;
            if (client.ResponseHasNoErrors(new ResponseChecker()))
                response = client.GetResponse<Response>();
        }
    }

    public class ResponseChecker : IResponseChecker
    {
        public bool CheckResponseIsOk(string response)
        {
            if (!response.Contains("error"))
                return true;

            return false;
        }
    }
}
