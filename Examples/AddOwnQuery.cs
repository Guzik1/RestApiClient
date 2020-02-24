using RestApiClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples
{
    public class AddOwnQuery
    {
        public void Example()
        {

            string url = @"testurl.com/api";

            RestClient client = new RestClient(url);

            Dictionary<string, string> query = new Dictionary<string, string>();
            query.Add("queryParam", "test");

            client.AddQuery(query);

            // Call to api:
            client.SendGET();

            Response response;
            if (client.ResponseHasNoErrors())
                response = client.GetResponse<Response>();
        }
    }
}
