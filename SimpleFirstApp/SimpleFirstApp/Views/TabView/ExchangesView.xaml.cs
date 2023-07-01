using SimpleFirstApp.ViewModels.TabViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleFirstApp.Views.TabView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExchangesView : ContentPage
    {
        public ExchangesView()
        {
            InitializeComponent();
            BindingContext = new ExchangesViewModel();
        }
    }
}