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
    /// <summary>
    /// Rest client manager.
    /// </summary>
    public partial class RestClient
    {
        string apiUri;

        HttpClient client = new HttpClient();
        HttpResponseMessage response;

        MethodSender ms;

        /// <summary>
        /// Inicjalize rest client with api url.
        /// </summary>
        /// <param name="apiUri">Api url.</param>
        public RestClient(string apiUri)
        {
            this.apiUri = apiUri;

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            ms = new MethodSender(client);
        }

        /// <summary>
        /// Send request using checked method.
        /// </summary>
        /// <param name="method">Method type.</param>
        public void Send(MethodsType method)
        {
            switch (method)
            {
                case MethodsType.GET:
                    SendGET();
                    break;
                case MethodsType.DELETE:
                    SendDELETE();
                    break;
                case MethodsType.POST:
                    SendPOST<object>(null);
                    break;
                case MethodsType.PUT:
                    SendPUT<object>(null);
                    break;
            }
        }

        /// <summary>
        /// Send request with data using checked method.
        /// </summary>
        /// <param name="method">Method type.</param>
        /// <param name="objectToSend">Data to send.</param>
        public void Send(MethodsType method, object objectToSend = null)
        {
            if (method != MethodsType.POST || method != MethodsType.PUT)
                Send(method);

            switch (method)
            {
                case MethodsType.POST:
                    SendPOST(objectToSend);
                    break;
                case MethodsType.PUT:
                    SendPUT(objectToSend);
                    break;
            }
        }

        /// <summary>
        /// Send get request.
        /// </summary>
        public void SendGET()
        {
            AddHeaderToRequest();
            response = ms.GetMethod(apiUri);
        }

        /// <summary>
        /// Send post request with data.
        /// </summary>
        /// <typeparam name="T">Type of data to send</typeparam>
        /// <param name="dataToSend">generic object data to send (type T).</param>
        public void SendPOST<T>(T dataToSend)
        {
            AddHeaderToRequestPost<T>(dataToSend);
            response = ms.PostMethod<T>(dataToSend, apiUri);
        }

        /// <summary>
        /// Send delete request.
        /// </summary>
        public void SendDELETE()
        {
            AddHeaderToRequest();
            response = ms.DeleteMethod(apiUri);
        }

        /// <summary>
        /// Send put request with data.
        /// </summary>
        /// <typeparam name="T">Type of data to send</typeparam>
        /// <param name="dataToSend">generic object data to send (type T).</param>
        public void SendPUT<T>(T dataToSend)
        {
            AddHeaderToRequest();
            response = ms.PutMethod<T>(dataToSend, apiUri);
        }

        internal HttpClient GetHttpClient => client;

        /// <summary>
        /// Response has success status code.
        /// </summary>
        public bool ResponseHasSuccessStatusCode => response.IsSuccessStatusCode;

        /// <summary>
        /// Check response has no errors.
        /// </summary>
        /// <returns>True when response have no error, or false in else.</returns>
        public bool ResponseHasNoErrors()
            => ResponseHasSuccessStatusCode;

        /// <summary>
        /// Check response has no errors, with own response checker.
        /// </summary>
        /// <returns>True when response have no error, or false in else.</returns>
        public bool ResponseHasNoErrors(IResponseChecker checker) 
            => ResponseHasSuccessStatusCode && checker.CheckResponseIsOk(GetResponseToString);

        /// <summary>
        /// Get response status code.
        /// </summary>
        public int GetStatusCode => (int)response.StatusCode;

        /// <summary>
        /// Get message from response.
        /// </summary>
        public string GetResponseToString => response.Content.ReadAsStringAsync().Result;

        /// <summary>
        /// Get response generic object from response.
        /// </summary>
        /// <typeparam name="T">Type of response object data.</typeparam>
        /// <returns>Response object</returns>
        public T GetResponse<T>()
            => Deserialize.FromJson<T>(GetResponseToString);

        /// <summary>
        /// Get response generic object from response, using own response deserializer.
        /// </summary>
        /// <typeparam name="T">Type of response object data.</typeparam>
        /// <returns>Response object</returns>
        public T GetResponse<T>(IResponseDeserializer<T> ownResponseDeserializer)
            => ownResponseDeserializer.Deserialize(GetResponseToString);

        /// <summary>
        /// Get dynamic object response from responde on request.
        /// </summary>
        /// <returns>Dynamic response.</returns>
        public dynamic GetResponseDynamic()
            => Deserialize.FromJson(GetResponseToString);

        /// <summary>
        /// Write response in console.
        /// </summary>
        public void WriteResponseInScreen() => Console.WriteLine(GetResponseToString);
    }
}