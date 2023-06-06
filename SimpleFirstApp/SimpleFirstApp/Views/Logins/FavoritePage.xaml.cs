using SimpleFirstApp.Models;
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
    public partial class FavoritePage : ContentPage
    {
        public FavoritePage()
        {
            InitializeComponent();
        }
        private async void btnRegister_Clicked(object sender, EventArgs e)
        {
            var account = (RelatedObject)BindingContext;
            if (!String.IsNullOrEmpty(account.SomeData))
            {
                account.UserId = Xamarin.Essentials.Preferences.Get("UserLogin", "user"); ;
                await App.Database.SaveRelatedObjectItemAsync(account);
            }
            await this.Navigation.PopAsync();
            DisplayAlert("", "registration Successful!", "OK");
        }
    }
}