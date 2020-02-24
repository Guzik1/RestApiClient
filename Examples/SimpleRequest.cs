using System;
using RestApiClient;

namespace Examples
{
    public class SimpleRequest
    {
        public void Example()
        {
            string url = @"testurl.com/api";

            RestClient client = new RestClient(url);

            // data to send post and put method.
            DataToSend data = new DataToSend() { Field1 = "test", Int2 = 21 };

            // Chose request type:
            client.SendGET();    // send get request, or
            client.SendDELETE();    // send delete request or
            client.SendPOST(data);   // send post request with data or
            client.SendPUT(data);   // send put request with data.

            Response response;
            if (client.ResponseHasNoErrors())
                response = client.GetResponse<Response>();
        }
    }

    public class DataToSend
    {
        public string Field1 { get; set; }

        public int Int2 { get; set; }
    }

    public class Response
    {
        public int Id { get; set; }

        public string Result { get; set; }

        public string Params { get; set; }
    }
}
