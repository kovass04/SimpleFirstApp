using SimpleFirstApp.Models;
using SimpleFirstApp.ViewModels.TabViewModels;
using SimpleFirstApp.Views.Logins;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleFirstApp.Views.TabView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }
        private async void SettingButton_Click(object sender, EventArgs e)
        {
            //Open the ChartsView page
            await Navigation.PushAsync(new SettingView());
        }
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            //check verification of account login
            var getUserSavedKey = Xamarin.Essentials.Preferences.Get("UserAlreadyloggedIn", false);

            if (getUserSavedKey)
            {
                //TODO need to complete adding crypto to your profile.
            }
            else
            {
                // Open login page
                await Navigation.PushAsync(new LoginPage1());
            }
        }
        /// <summary>
        /// The event handler for selecting a list item.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">Arguments of the event.</param>
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Assets selectedAssetData = (Assets)e.SelectedItem;

            // Open the ChartsView page with the selected asset ID
            await Navigation.PushAsync(new ChartsView(selectedAssetData.id));
        }
    }
}