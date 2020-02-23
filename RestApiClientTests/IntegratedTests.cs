using NUnit.Framework;
using RestApiClient;

namespace RestApiClientTests
{
    public class Tests
    {
        [Test]
        public void SendGetMetodTest()
        {
            RestClient rm = new RestClient("https://httpbin.org/get");
            rm.SendGET();
            int statusCode = rm.GetStatusCode;

            Assert.AreEqual(statusCode, 200);
            Assert.IsTrue(rm.ResponseHasSuccessStatusCode);
        }

        [Test]
        public void SendPostMetodTest()
        {
            RestClient rm = new RestClient("https://httpbin.org/post");
            rm.SendPOST<object>(null);
            int statusCode = rm.GetStatusCode;

            Assert.AreEqual(statusCode, 200);
            Assert.IsTrue(rm.ResponseHasSuccessStatusCode);
        }

        [Test]
        public void SendDeleteMetodTest()
        {
            RestClient rm = new RestClient("https://httpbin.org/delete");
            rm.SendDELETE();
            int statusCode = rm.GetStatusCode;

            Assert.AreEqual(statusCode, 200);
            Assert.IsTrue(rm.ResponseHasSuccessStatusCode);
        }

        [Test]
        public void SendPutMetodTest()
        {
            RestClient rm = new RestClient("https://httpbin.org/put");
            rm.SendPUT<object>(null);
            int statusCode = rm.GetStatusCode;

            Assert.AreEqual(statusCode, 200);
            Assert.IsTrue(rm.ResponseHasSuccessStatusCode);
        }
    }
}