using SimpleFirstApp.Models;
using SimpleFirstApp.ViewModels;
using SimpleFirstApp.ViewModels.TabViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace SimpleFirstApp.Views.TabView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurrencyView : ContentPage
    {
        CurrencyViewModel _viewModel;
        public CurrencyView()
        {
            InitializeComponent();

            BindingContext = _viewModel = new CurrencyViewModel();
        }
        void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (picker1.SelectedIndex != -1 && picker2.SelectedIndex != -1)
            {
                BindingContext = _viewModel = new CurrencyViewModel(picker1.Items[picker1.SelectedIndex], picker2.Items[picker2.SelectedIndex]);
            }
            else if (picker1.SelectedIndex == -1)
            {
                BindingContext = _viewModel = new CurrencyViewModel(picker1.Items[0], picker2.Items[picker2.SelectedIndex]);
            }
            else if (picker2.SelectedIndex == -1)
            {
                BindingContext = _viewModel = new CurrencyViewModel(picker1.Items[picker1.SelectedIndex], picker2.Items[0]);
            }
            else
            {
                BindingContext = _viewModel = new CurrencyViewModel(picker1.Items[0], picker2.Items[0]);
            }
        }
        private void OnConvertClicked(object sender, EventArgs e)
        {
            if (int.TryParse(numberEntry.Text, out int value))
            {

                // Perform the conversion using the integer value
                // ...
                numberWrite.Text = $"{double.Parse(_viewModel.firstItem) * value}";
            }
            else
            {
                // Display an error message if the input is not a valid integer
                DisplayAlert("Error", "Please enter a valid integer", "OK");
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}