using System;
using System.Collections.Generic;
using System.Text;  
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Globalization;
using System.Web;
using System.Collections.Specialized;

namespace RestApiClient
{
    public partial class RestClient
    {
        string apiUri;

        HttpClient client = new HttpClient();
        HttpResponseMessage response;

        MethodSender ms;

        public RestClient(string apiUri)
        {
            this.apiUri = apiUri;

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            ms = new MethodSender(client);
        }

        public void SendGET()
        {
            AddHeaderToRequest();
            response = ms.GetMethod(apiUri);
        }

        public void SendPOST<T>(T dataToSend)
        {
            AddHeaderToRequestPost<T>(dataToSend);
            response = ms.PostMethod<T>(dataToSend, apiUri);
        }

        public void SendDELETE()
        {
            AddHeaderToRequest();
            response = ms.DeleteMethod(apiUri);
        }

        public void SendPUT<T>(T dataToSend)
        {
            AddHeaderToRequest();
            response = ms.PutMethod<T>(dataToSend, apiUri);
        }

        protected HttpClient GetHttpClient => client;

        public bool ResponseHasSuccessStatusCode => response.IsSuccessStatusCode;

        public bool ResponseHasNoErrors()
            => ResponseHasSuccessStatusCode;

        public bool ResponseHasNoErrors(IResponseChecker checker) 
            => ResponseHasSuccessStatusCode && checker.CheckResponseIsOk(GetResponseToString);

        public int GetStatusCode => (int)response.StatusCode;

        public string GetResponseToString => response.Content.ReadAsStringAsync().Result;

        public T GetResponse<T>()
            => Deserialize.FromJson<T>(GetResponseToString);

        public T GetResponse<T>(IDeserializable<T> ownDeserializer)
            => ownDeserializer.Deserialize(GetResponseToString);

        public dynamic GetResponseDynamic()
            => Deserialize.FromJson(GetResponseToString);

        public void WriteResponseInScreen() => Console.WriteLine(GetResponseToString);
    }
}