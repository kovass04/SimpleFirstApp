using SimpleFirstApp.Models;
using SimpleFirstApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleFirstApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }
        public void OnAppearing()
        {
            IsBusy = true;
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        public string firstItem;//fix
        private readonly DataServices _Services;
        private List<Assets> _assets;
        private List<Exchanges> _exchanges;
        private List<AssetsMarkets> _marks;
        private List<Charts> _charts;
        public List<Assets> Asset
        {
            get => _assets;
            set
            {
                SetProperty(ref _assets, value);
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
        public List<AssetsMarkets> Market
        {
            get => _marks;
            set
            {
                SetProperty(ref _marks, value);
            }
        }
        public List<Charts> Charts
        {
            get => _charts;
            set
            {
                SetProperty(ref _charts, value);
            }
        }
        protected async Task LoadAssetsAsync()
        {
            var assets = await _Services.GetAssetsAsync();
            Asset = new List<Assets>(assets.data);
        }
        protected async Task LoadAssetsAsync(string id)
        {
            var assets = await _Services.GetAssetsIdAsync(id);
            firstItem = assets.data.priceUsd;
        }
        protected async Task LoadExchangesAsync()
        {
            var exchanges = await _Services.GetExchangesAsync();
            Exchange = exchanges.data.Take(50).ToList();

        }
        //Market start f()
        protected async Task LoadMarketsAsync(string id)
        {
            var markets = await _Services.GetMarketsIdAsync(id);
            Market = new List<AssetsMarkets>(markets.data);
        }
        //Market sort f()
        protected async Task LoadMarketsAsync(string id, bool sortDescending)
        {
            var markets = await _Services.GetMarketsIdAsync(id);

            if (sortDescending)
            {
                Market = markets.data.OrderByDescending(m => m.priceUsd).ToList();
            }
            else
            {
                Market = markets.data.OrderBy(m => m.priceUsd).ToList();
            }
        }
        //Market end f()
        protected async Task LoadChartsAsync(string i, string b)
        {
            var charts = await _Services.GetChartsAsync(i, b);
            Charts = new List<Charts>(charts.data);
        }
        public BaseViewModel()
        {
            _Services = new DataServices();
        }
    }
}
