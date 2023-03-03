using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using SimpleFirstApp.Models;
using SimpleFirstApp.Services;


namespace SimpleFirstApp.Services
{

    public class AssetServices
    {
        private readonly HttpClient _httpClient;

        public AssetServices()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://api.coincap.io/v2/");
        }

        public async Task<Data> GetAssetsAsync()
        {
            var response = await _httpClient.GetAsync("assets");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Data>(content);
        }

        /*public async Task<List<Asset>> GetAssetAsync()
        {
            RestClient<Asset> restClient = new RestClient<Asset>();

            var assetList = await restClient.GetAsync();

            return assetList;
        }*/


        private const string Uri = "https://cryptingup.com/api/assets";

        private const string Uri_2 = "https://api.coincap.io/v2/assets";

        //static HttpClient httpClient = new HttpClient();

        /*public async Task<List<Asset>> GetAssetAsync()
        {
            string json = await httpClient.GetStringAsync(Uri);

            var assetList = JsonConvert.DeserializeObject<List<Asset>>(json);

            return assetList;
        }  */
        /*        public string makeAPICall()
                {
                    var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/category");



                    var client = new WebClient();
                    client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
                    client.Headers.Add("Accepts", "application/json");
                    return client.DownloadString(URL.ToString());
                }*/
        /*public async Task<Datum> GetAssetAsync()
        {
            string json = await httpClient.GetStringAsync(Uri_2);

            string a = json;

            var assetList = JsonConvert.DeserializeObject<Datum>(json);

            return assetList;


        }*/

        /*public async Task<Data> GetAssetAsync()
        {
            var response = await httpClient.GetAsync("https://api.coincap.io/v2/assets");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Data>(content);
        }*/
    }
}
