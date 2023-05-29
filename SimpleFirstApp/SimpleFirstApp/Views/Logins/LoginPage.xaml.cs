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
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            BindingContext = new LoginViewModel();
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
            Navigation.PushAsync(new RegistrationPage());
        }
        private void btnAll_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AccPage());
        }
    }
}