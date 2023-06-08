using SimpleFirstApp.Views.Logins;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SimpleFirstApp.ViewModels.Login
{
    internal class FavoritePageViewModel
    {
        public ICommand LogoutCommand { get; }


        public FavoritePageViewModel()
        {
            LogoutCommand = new Command(PerformLogoutOperation);
        }

        private async void PerformLogoutOperation(object obj)
        {
            Preferences.Clear();

            await Application.Current.MainPage.Navigation.PushAsync(new LoginPage1());
        }
    }
}
