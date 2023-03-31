using SimpleFirstApp.Models;
using SimpleFirstApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFirstApp.ViewModels
{
    public class MarketIdViewModel : BaseViewModel
    {
        private readonly DataServices _Services;
        public MarketIdViewModel(string id)
        {
            Title = id;

        }

        /*        private async Task LoadMarketsAsync(string id)
                {

                    var markets = await _Services.GetMarketsIdAsync(id);
                    Market = new List<AssetsMarkets>(markets.data);
                }*/

        public void OnAppearing()
        {
            IsBusy = true;
        }
    }
}
