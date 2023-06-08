using SimpleFirstApp.Models;
using SimpleFirstApp.ViewModels.Login;
using SimpleFirstApp.Views.TabView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleFirstApp.Views.Logins
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage1 : ContentPage
    {
        public LoginPage1()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
        protected override async void OnAppearing()
        {
            await App.Database.CreateTable();
            base.OnAppearing();
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Account account = new Account();
            RegistrationPage accountPage = new RegistrationPage();
            accountPage.BindingContext = account;
            await Navigation.PushAsync(accountPage);
        }

        private void btnSkip_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomeView());
        }
    }
}