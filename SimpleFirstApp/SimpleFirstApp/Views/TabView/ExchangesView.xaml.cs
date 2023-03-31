using SimpleFirstApp.ViewModels.TabViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleFirstApp.Views.TabView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExchangesView : ContentPage
    {
        ExchangesViewModel _viewModel;
        public ExchangesView()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ExchangesViewModel();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}