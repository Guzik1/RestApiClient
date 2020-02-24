using System;
using System.Collections.Generic;
using System.Text;
using RestApiClient;
using System.Text.Json;

namespace Examples
{
    public class AddOwnHeaders
    {
        public void Example()
        {
            string url = @"testurl.com/api";

            RestClient client = new RestClient(url);
            client.AddOwnHeaderToRequest(new AddHeaderClass());

            // data to send post and put method.
            DataToSend2 data = new DataToSend2() { Field1 = "test", Int2 = 57 };

            // Call to api:
            client.SendGET();    // send get request, call to AddOwnHeader method.
            /* or */
            client.SendPOST(data);   // send post request with data, call to AddOwnHeaderPOST method.

            Response response;
            if (client.ResponseHasNoErrors())
                response = client.GetResponse<Response>();
        }
    }

    public class AddHeaderClass : IAddOwnHeaderToRequest
    {
        // Call on get, put, delete request.
        public Dictionary<string, string> AddOwnHeader()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("key1", "value1");
            headers.Add("date", DateTime.Now.ToString());
            headers.Add("key2", "25");

            return headers;
        }

        // Call on post request.
        public Dictionary<string, string> AddOwnHeaderPOST(object POSTDataToSend)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("key1", "value1");
            headers.Add("date", DateTime.Now.ToString());
            headers.Add("data", JsonSerializer.Serialize(POSTDataToSend));
            headers.Add("key2", "22");

            return headers;
        }
    }

    public class DataToSend2
    {
        public string Field1 { get; set; }

        public int Int2 { get; set; }
    }

}
