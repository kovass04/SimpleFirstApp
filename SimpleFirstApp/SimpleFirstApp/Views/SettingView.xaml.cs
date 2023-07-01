using SimpleFirstApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleFirstApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingView : ContentPage
    {
        public SettingView()
        {
            InitializeComponent();
            BindingContext = new SettingViewModel();
        }
    }
}