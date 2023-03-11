using SimpleFirstApp.ViewModels.TabViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
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
    }
}