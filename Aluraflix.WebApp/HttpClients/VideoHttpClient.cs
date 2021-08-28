using System;
using System.Net.Http;

namespace Aluraflix.WebApp.HttpClients
{
    public class VideoHttpClient
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5000/");
            return client;
        }
    }
}
