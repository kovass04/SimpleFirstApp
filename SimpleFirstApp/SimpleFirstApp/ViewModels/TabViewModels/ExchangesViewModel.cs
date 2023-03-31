using SimpleFirstApp.Models;
using SimpleFirstApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFirstApp.ViewModels.TabViewModels
{
    public class ExchangesViewModel : BaseViewModel
    {
        private readonly DataServices _Services;
        private List<Exchanges> _exchanges;

        public List<Exchanges> Exchange
        {
            get => _exchanges;
            set
            {
                SetProperty(ref _exchanges, value);
            }
        }

        public ExchangesViewModel()
        {
            Title = "Markets Page";
            _Services = new DataServices();
            LoadExchangesAsync();
        }

        private async Task LoadExchangesAsync()
        {
            var exchanges = await _Services.GetExchangesAsync();
            Exchange = new List<Exchanges>(exchanges.data);
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }
    }
}
