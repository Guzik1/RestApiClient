using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace RestApiClient
{
    internal class MethodSender
    {
        HttpClient client;

        internal MethodSender(HttpClient client)
        {
            this.client = client;
        }

        internal HttpResponseMessage GetMethod(string apiUrl) 
        {
            return client.GetAsync(apiUrl).Result;
        }

        internal HttpResponseMessage PostMethod<T>(T data, string apiUrl)
        {
            string json = Serialize.AsJson(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return client.PostAsync(apiUrl, content).Result;
        }

        internal HttpResponseMessage DeleteMethod(string apiUrl)
        {
            return client.DeleteAsync(apiUrl).Result;
        }

        internal HttpResponseMessage PutMethod<T>(T data, string apiUrl)
        {
            string json = Serialize.AsJson(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return client.PutAsync(apiUrl, content).Result;
        }
    }
}
