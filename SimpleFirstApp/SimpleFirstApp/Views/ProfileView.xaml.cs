using SimpleFirstApp.ViewModels;
using SimpleFirstApp.Views.TabView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleFirstApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileView : ContentPage
    {
        ProfileViewModel _viewModel;
        public ProfileView()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ProfileViewModel();
        }
        private async void BackButton_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomeView());
        }
    }
}