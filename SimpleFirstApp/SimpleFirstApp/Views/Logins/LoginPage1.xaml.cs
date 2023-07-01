using SimpleFirstApp.Models;
using SimpleFirstApp.ViewModels.Login;
using SimpleFirstApp.Views.TabView;
using System;
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

        /// <summary>
        /// The event handler for a touch event on an element.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param
        /// <param name="e">Event arguments.</param>
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Account account = new Account();
            RegistrationPage accountPage = new RegistrationPage();
            accountPage.BindingContext = account;

            // Open the account registration page
            await Navigation.PushAsync(accountPage);
        }

        /// <summary>
        /// Event handler for clicking the "Skip" button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param
        /// <param name="e">Event arguments.</param>
        private void btnSkip_Clicked(object sender, EventArgs e)
        {
            // Go to the HomeView page
            Navigation.PushAsync(new HomeView());
        }
    }
}