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

        public List<Assets> Asset
        {
            get => _assets;
            set
            {
                SetProperty(ref _assets, value);
            }
        }

        public HomeViewModel()
        {
            Title = "Homepage";
            _Services = new DataServices();
            LoadAssetsAsync();
        }

        private async Task LoadAssetsAsync()
        {
            var assets = await _Services.GetAssetsAsync();
            Asset = new List<Assets>(assets.data);
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

    }
}
