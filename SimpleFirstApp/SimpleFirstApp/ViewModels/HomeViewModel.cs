using Newtonsoft.Json;
using SimpleFirstApp.Models;
using SimpleFirstApp.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace SimpleFirstApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            Title = "HomePage or not";
            //LoadData();
            //_model.asset_id = "sda";
        }



        /*public async void LoadData()
        {
            string url = "https://cryptingup.com/api/assets";

            HttpClient client = new HttpClient();
            while (response == null)
            {
                response = await client.GetStringAsync(url);
            }
            var temp = JsonConvert.DeserializeObject<Rootobject>(response);
            _model = new Asset();
            foreach (Asset item in temp.assets)
            {
                _model.asset_id = item.asset_id;
            }
        }*/


    }
}