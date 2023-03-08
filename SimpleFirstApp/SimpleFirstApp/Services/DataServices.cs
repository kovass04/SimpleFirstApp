using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SimpleFirstApp.Models;

namespace SimpleFirstApp.Services
{
    public class DataServices
    {
        private readonly HttpClient _httpClient;

        public DataServices()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://api.coincap.io/v2/");
        }

        public async Task<DataAssets> GetAssetsAsync()
        {
            var response = await _httpClient.GetAsync("assets");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DataAssets>(content);
        }

        public async Task<DataMarkets> GetMarketsAsync()
        {
            var response = await _httpClient.GetAsync("markets");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DataMarkets>(content);
        }

        public async Task<DataExchanges> GetExchangesAsync()
        {
            var response = await _httpClient.GetAsync("exchanges");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DataExchanges>(content);
        }

    }
}
