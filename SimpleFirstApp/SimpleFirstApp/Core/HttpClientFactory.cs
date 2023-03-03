using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SimpleFirstApp.Core
{
    public class HttpClientFactory
    {
        private readonly HttpClient _httpClient;
        public HttpClientFactory()
        {
            _httpClient = new HttpClient();
        }

        public HttpClient GetHttpClient()
        {
            return _httpClient;
        }
    }
}
