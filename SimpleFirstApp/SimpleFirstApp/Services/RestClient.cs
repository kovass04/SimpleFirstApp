using Newtonsoft.Json;
using SimpleFirstApp.Core;
using SimpleFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace SimpleFirstApp.Services
{
    public class RestClient<T>
    {
        private const string Uri = "https://cryptingup.com/api/assets";

        static HttpClient httpClient = new HttpClient();
        public async Task<List<T>> GetAsync()
        {

            string json = await httpClient.GetStringAsync(Uri);       

            var taskModels = JsonConvert.DeserializeObject<List<T>>(json);

            return taskModels;
        }
    }
}
