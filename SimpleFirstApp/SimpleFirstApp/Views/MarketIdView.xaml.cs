using SimpleFirstApp.ViewModels;
using SimpleFirstApp.ViewModels.TabViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SimpleFirstApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarketIdView : ContentPage
    {
        MarketIdViewModel _viewModel;
        public MarketIdView(string i)
        {
            InitializeComponent();

            BindingContext = _viewModel = new MarketIdViewModel(i);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}