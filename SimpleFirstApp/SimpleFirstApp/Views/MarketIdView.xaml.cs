﻿using SimpleFirstApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleFirstApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarketIdView : ContentPage
    {
        public MarketIdView(string marketsId)
        {
            InitializeComponent();
            BindingContext = new MarketIdViewModel(marketsId);
        }
    }
}