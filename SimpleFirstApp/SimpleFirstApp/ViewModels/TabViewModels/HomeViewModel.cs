using SimpleFirstApp.Models;
using SimpleFirstApp.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SimpleFirstApp.ViewModels.TabViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly DataServices _Services;
        private List<Assets> _assets;
        private List<Markets> _marks;
        private List<Exchanges> _exchanges;

        public List<Assets> Asset
        {
            get => _assets;
            set
            {
                SetProperty(ref _assets, value);
            }
        }

        public List<Markets> Market
        {
            get => _marks;
            set
            {
                SetProperty(ref _marks, value);
            }
        }

        public List<Exchanges> Exchange
        {
            get => _exchanges;
            set
            {
                SetProperty(ref _exchanges, value);
            }
        }

        public HomeViewModel()
        {
            Title = "Homepage";
            _Services = new DataServices();
            LoadAssetsAsync();
            LoadMarketsAsync();
            LoadExchangesAsync();
        }

        private async Task LoadAssetsAsync()
        {
            var assets = await _Services.GetAssetsAsync();
            Asset = new List<Assets>(assets.data);
            Asset = Asset.Take(3).ToList();
        }

        private async Task LoadMarketsAsync()
        {
            var markets = await _Services.GetMarketsAsync();
            Market = new List<Markets>(markets.data);
            Market = Market.Take(3).ToList();
        }

        private async Task LoadExchangesAsync()
        {
            var exchanges = await _Services.GetExchangesAsync();
            Exchange = new List<Exchanges>(exchanges.data);
            Exchange = Exchange.Take(3).ToList();
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

    }
}
