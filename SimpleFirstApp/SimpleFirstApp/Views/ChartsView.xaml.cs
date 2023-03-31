using SimpleFirstApp.ViewModels;
using SimpleFirstApp.ViewModels.TabViewModels;
using SimpleFirstApp.Views.TabView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleFirstApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChartsView : ContentPage
    {
        ChartsViewModel _viewModel;
        public ChartsView(string i)
        {
            InitializeComponent();
            
            BindingContext = _viewModel = new ChartsViewModel(i);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
        private async void ProfileButton_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomeView());
        }
    }
}