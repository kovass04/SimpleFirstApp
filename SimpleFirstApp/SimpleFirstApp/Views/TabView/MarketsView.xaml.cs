using SimpleFirstApp.ViewModels.TabViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace SimpleFirstApp.Views.TabView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarketsView : ContentPage
    {
        MarketsViewModel _viewModel;
        public MarketsView()
        {
            InitializeComponent();
        
            BindingContext = _viewModel = new MarketsViewModel();
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

        void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            header.Text = "You choise: " + picker.Items[picker.SelectedIndex];
            BindingContext = _viewModel = new MarketsViewModel(picker.Items[picker.SelectedIndex]);
        }
        void picker_SelectedIndexChanged2(object sender, EventArgs e)
        {
            bool a;
            if (picker2.Items[picker2.SelectedIndex] == "Low") { a = false; }
            else { a = true; }
            //need to fix because I have -1 and not null
            if (picker.Items[picker.SelectedIndex] != null) 
            {
                BindingContext = _viewModel = new MarketsViewModel(picker.Items[picker.SelectedIndex], a);
            }
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            string marketId = (string)((Button)sender).CommandParameter;
            await Navigation.PushAsync(new MarketIdView(marketId));
        }

    }
}