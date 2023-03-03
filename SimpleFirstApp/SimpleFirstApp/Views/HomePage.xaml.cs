using Newtonsoft.Json;
using SimpleFirstApp.Core;
using SimpleFirstApp.Models;
using SimpleFirstApp.Services;
using SimpleFirstApp.ViewModels;
using System;
using System.ComponentModel;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleFirstApp.Views
{
    public partial class HomePage : ContentPage
    {
        
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
            LoadData();
        }

        public async void LoadData()
        {

            string url = "https://cryptingup.com/api/assets";

            //var rep = await _httpClientFactory.GetHttpClient().GetStringAsync(url);

            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(url);

            var temp = JsonConvert.DeserializeObject<Rootobject>(response);



            /*foreach (Asset item in temp.assets)
            {
                Label label = new Label
                {
                    Text = item.asset_id
                };

                Content = label;
            }*/

            /*StackLayout stackLayout5 = new StackLayout();
            foreach (Asset item in temp.assets)
            {
                Label label = new Label
                {
                    Text = item.asset_id
                };
                stackLayout5.Children.Add(label);
            }
            ScrollView scrollView = new ScrollView();
            scrollView.Content = stackLayout5;
            this.Content = scrollView;*/
        }
    }
}