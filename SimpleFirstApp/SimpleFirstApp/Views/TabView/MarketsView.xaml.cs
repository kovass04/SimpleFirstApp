using SimpleFirstApp.ViewModels.TabViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleFirstApp.Views.TabView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarketsView : ContentPage
    {
        public MarketsView()
        {
            InitializeComponent();
            BindingContext = new MarketsViewModel();
        }

        /// <summary>
        /// Event handler for changing the selected item in the selector.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param
        /// <param name="e">Event arguments.</param>
        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            header.Text = "You choise: " + picker.Items[picker.SelectedIndex];

            // Set a new model of the market type with the selected element
            BindingContext = new MarketsViewModel(picker.Items[picker.SelectedIndex]);
        }
        private void picker_SelectedIndexChanged2(object sender, EventArgs e)
        {
            //TODO make normal picker
            bool sort;
            if (picker2.Items[picker2.SelectedIndex] == "Low") 
            {
                sort = false; 
            }
            else 
            { 
                sort = true; 
            }
            //TODO need to fix because take -1 instead of null
            if (picker.Items[picker.SelectedIndex] != null) 
            {
                // Set a new model of the market type with the selected element
                BindingContext = new MarketsViewModel(picker.Items[picker.SelectedIndex], sort);
            }
        }

        /// <summary>
        /// Button click event handler.
        /// </summary>
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            // Get the market identifier from the button command parameter
            string marketId = (string)((Button)sender).CommandParameter;

            // Open the MarketIdView page with the passed market identifier
            await Navigation.PushAsync(new MarketIdView(marketId));
        }

    }
}