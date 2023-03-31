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

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            string marketId = (string)((Button)sender).CommandParameter;
            await Navigation.PushAsync(new MarketIdView(marketId));
        }

        private async void ChartsButton_Click(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new ChartsView());
        }
    }
}