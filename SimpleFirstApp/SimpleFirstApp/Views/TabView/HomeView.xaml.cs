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
    public partial class HomeView : ContentPage
    {
        HomeViewModel _viewModel;
        public HomeView()
        {
            InitializeComponent();

            BindingContext = _viewModel = new HomeViewModel();

        }
        private async void ProfileButton_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingView());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}