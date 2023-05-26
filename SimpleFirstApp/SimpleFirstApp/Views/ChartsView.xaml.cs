using SimpleFirstApp.ViewModels;
using SimpleFirstApp.ViewModels.TabViewModels;
using SimpleFirstApp.Views.TabView;
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
    public partial class ChartsView : ContentPage
    {
        ChartsViewModel _viewModel;
        static string n;
        public ChartsView(string i)
        {
            InitializeComponent();
            n = i;
            BindingContext = _viewModel = new ChartsViewModel(i, "1d");
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

        void Handle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (segmentedControl.SelectedIndex == 0)
            {
                BindingContext = _viewModel = new ChartsViewModel(n, "m1");
            }
            else if (segmentedControl.SelectedIndex == 1)
            {
                BindingContext = _viewModel = new ChartsViewModel(n, "h1");
            }
            else
            {
                BindingContext = _viewModel = new ChartsViewModel(n, "d1");
            }
        }


    }
}