using SimpleFirstApp.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Linq;
using SimpleFirstApp.ViewModels.Login;

namespace SimpleFirstApp.Views.Logins
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoritePage : ContentPage
    {
        public FavoritePage()
        {
            InitializeComponent();
            BindingContext = new FavoritePageViewModel();
        }

        protected override async void OnAppearing()
        {
            await App.Database.CreateTable();
            var items = await App.Database.GetItemsAsync();
            list.ItemsSource = items.Where(item => item.UserId == Xamarin.Essentials.Preferences.Get("UserLogin", "user"))
                                    .OrderBy(item => item.UserId);
            base.OnAppearing();
        }
    }
}