﻿using SimpleFirstApp.Models;
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
        HomeViewModel _viewModel;
        public HomeView()
        {
            InitializeComponent();
            BindingContext = _viewModel = new HomeViewModel();
        }
        private async void ProfileButton_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage1());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            var getuserSavedkey = Xamarin.Essentials.Preferences.Get("UserAlreadyloggedIn", false);

            if (getuserSavedkey)
            {
                //add.Text = "Add to favorite";
            }
            else
            {
                
                await Navigation.PushAsync(new LoginPage1());
            }
            
        }

        private List<Assets> _assets;
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Assets selectedAssetData = (Assets)e.SelectedItem;

            await Navigation.PushAsync(new ChartsView(selectedAssetData.id));
 
        }
    }
}