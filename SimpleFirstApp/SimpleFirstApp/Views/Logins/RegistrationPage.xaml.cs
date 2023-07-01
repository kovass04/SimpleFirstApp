using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SimpleFirstApp.Models;

namespace SimpleFirstApp.Views.Logins
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the registration button click event.
        /// </summary>
        private async void btnRegister_Clicked(object sender, EventArgs e)
        {
            var account = (Account)BindingContext;
            if (!String.IsNullOrEmpty(account.FirstName))
            {
                // Save account
                await App.Database.SaveItemAsync(account);
            }

            // Go back
            await this.Navigation.PopAsync();

            // Show notification of successful registration
            _ = DisplayAlert("", "registration Successful!", "OK");
        }
    }
}