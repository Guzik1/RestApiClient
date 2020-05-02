using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;

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
            try
            {
                return client.GetAsync(apiUrl).Result;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        internal HttpResponseMessage PostMethod<T>(T data, string apiUrl)
        {
            string json = Serialize.AsJson(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                return client.PostAsync(apiUrl, content).Result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        internal HttpResponseMessage DeleteMethod(string apiUrl)
        {
            try
            {
                return client.DeleteAsync(apiUrl).Result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        internal HttpResponseMessage PutMethod<T>(T data, string apiUrl)
        {
            string json = Serialize.AsJson(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                return client.PutAsync(apiUrl, content).Result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
