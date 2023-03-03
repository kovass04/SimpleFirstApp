using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SimpleFirstApp.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using SimpleFirstApp.Models;
using SimpleFirstApp.ViewModels;

namespace SimpleFirstApp.Services
{
    public class Loag
    {
        private readonly HttpClientFactory _httpClientFactory;

        private const string Uri = "https://cryptingup.com/api/assets";

        public Loag(HttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<Asset>> GetAssetsssss()
        {
            var json = await _httpClientFactory.GetHttpClient().GetStringAsync(Uri);

            var products = JsonConvert.DeserializeObject<List<Asset>>(json);

            return products;
        }
    }
}
