using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFirstApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleFirstApp.Views.Logins
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccPage : ContentPage
    {

        public AccPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            await App.Database.CreateTable();
            // привязка данных
            friendsList.ItemsSource = await App.Database.GetItemsAsync();

            base.OnAppearing();
        }
        private async void CreateFriend(object sender, EventArgs e)
        {
            Account account = new Account();
            RegistrationPage accountPage = new RegistrationPage();
            accountPage.BindingContext = account;
            await Navigation.PushAsync(accountPage);
        }
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Account selectedAccount = (Account)e.SelectedItem;
            RegistrationPage accountPage = new RegistrationPage();
            accountPage.BindingContext = selectedAccount;
            await Navigation.PushAsync(accountPage);
        }
    }
}