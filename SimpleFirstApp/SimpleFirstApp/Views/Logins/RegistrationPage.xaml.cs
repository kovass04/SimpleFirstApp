using SimpleFirstApp.Views.TabView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
        
        private async void btnRegister_Clicked(object sender, EventArgs e)
        {
            var account = (Account)BindingContext;
            if (!String.IsNullOrEmpty(account.FirstName))
            {
                await App.Database.SaveItemAsync(account);
            }
            await this.Navigation.PopAsync();
            DisplayAlert("", "registration Successful!", "OK");
        }
    }
}