using SimpleFirstApp.Views;
using SimpleFirstApp.Views.Logins;
using SimpleFirstApp.Views.TabView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SimpleFirstApp.ViewModels
{
    public class WelcomePageViewModel : BaseViewModel
    {
        public Task Init { get; }

        public WelcomePageViewModel()
        {
            Init = Initialize();
        }
        private async Task Initialize()
        {
            VersionTracking.Track();
            if (VersionTracking.IsFirstLaunchEver)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new LoginPage1());
            }
            else
            {
                await Application.Current.MainPage.Navigation.PushAsync(new HomeView());
            }
        }
    }
}
