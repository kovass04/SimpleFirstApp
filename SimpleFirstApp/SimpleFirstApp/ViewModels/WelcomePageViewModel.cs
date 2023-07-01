using SimpleFirstApp.Views.Logins;
using SimpleFirstApp.Views.TabView;
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
            // Checking for starts
            VersionTracking.Track();
            if (VersionTracking.IsFirstLaunchEver)
            {
                // Open the Login page
                await Application.Current.MainPage.Navigation.PushAsync(new LoginPage1());
            }
            else
            {
                // Open the Home page
                await Application.Current.MainPage.Navigation.PushAsync(new HomeView());
            }
        }
    }
}
