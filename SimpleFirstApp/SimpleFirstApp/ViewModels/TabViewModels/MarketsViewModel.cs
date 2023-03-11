using SimpleFirstApp.Models;
using SimpleFirstApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFirstApp.ViewModels.TabViewModels
{
    public class MarketsViewModel : BaseViewModel
    {
        private readonly DataServices _Services;
        private List<AssetsMarkets> _marks;

        public List<AssetsMarkets> Market
        {
            get => _marks;
            set
            {
                SetProperty(ref _marks, value);
            }
        }

        public MarketsViewModel()
        {
            string a = "bitcoin";
            Title = "Markets Page";
            _Services = new DataServices();
            LoadMarketsAsync(a);
        }

        public MarketsViewModel(string id)
        {
            Title = "id";
            _Services = new DataServices();
            LoadMarketsAsync(id);
        }

        private async Task LoadMarketsAsync(string id)
        {
            
            var markets = await _Services.GetMarketsIdAsync(id);
            Market = new List<AssetsMarkets>(markets.data);
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }
    }
}
