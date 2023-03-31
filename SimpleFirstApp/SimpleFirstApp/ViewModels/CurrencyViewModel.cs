using SimpleFirstApp.Models;
using SimpleFirstApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFirstApp.ViewModels
{
    public class CurrencyViewModel : BaseViewModel
    {
        public string firstItem;
        private readonly DataServices _Services;
        public CurrencyViewModel()
        {
            Title = "Currency";
            _Services = new DataServices();
        }
        public CurrencyViewModel(string id,string id2)
        {
            Title = "Currency";
            _Services = new DataServices();
            LoadAssetsAsync(id);
        }

        private async Task LoadAssetsAsync(string id)
        {
            var assets = await _Services.GetAssetsIdAsync(id);
            firstItem = assets.data.priceUsd;
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }
    }
}
