using Newtonsoft.Json;
using SimpleFirstApp.Core;
using SimpleFirstApp.Models;
using SimpleFirstApp.Services;
using SimpleFirstApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleFirstApp.ViewModels
{
    public class MyViewModel : BaseViewModel
    {
        private readonly AssetServices _AssetServices;
        private List<Datum> _assets;

        
        public MyViewModel()
        {
            IsRefreshing = false;
            _AssetServices = new AssetServices();
            LoadAssetsAsync();
        }

        private async Task LoadAssetsAsync()
        {
            var assets = await _AssetServices.GetAssetsAsync();
            Datums = new List<Datum>(assets.data);
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        public List<Datum> Datums
        {
            get => _assets;
            set
            {
                SetProperty(ref _assets, value);
            }
        }


        /*public List<Datum> Datums
        {
            get => _assets;
            set
            {
                _assets = value;
                OnPropertyChanged();
            }
        }*/

        /*private Data _assetList;

        public Data AssetList
        {
            get { return _assetList; }
            set { _assetList = value;
                OnPropertyChanged();
            }
        }

        public Command LoadItemsCommand { get; }
        public MyViewModel()
        {
            LoadItemsCommand = new Command(async () => await InitializeDataAsync());
            IsRefreshing = false;
            InitializeDataAsync();
        }

        private async Task InitializeDataAsync()
        {
            var assetServices = new AssetServices();
            
            AssetList = await assetServices.GetAssetAsync();
        }*/

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }


        private bool isRefreshing;

        public bool IsRefreshing
        {
            get => isRefreshing;
            set
            {
                isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }
        /*public ICommand RefreshCommand => new Command(async () =>
        {
            IsRefreshing = true;
            await LoadAssetsAsync(); // Replace with your method to refresh the data
            IsRefreshing = false;
        });*/
    }
}

