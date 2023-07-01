using SimpleFirstApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleFirstApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChartsView : ContentPage
    {
        private string cryptoName;
        public ChartsView(string cryptoName)
        {
            InitializeComponent();
            this.cryptoName = cryptoName;
            BindingContext = new ChartsViewModel(cryptoName, "h1");
        }
        private void Handle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (segmentedControl.SelectedIndex == 0)
            {
                BindingContext = new ChartsViewModel(cryptoName, "m1");
            }
            else if (segmentedControl.SelectedIndex == 1)
            {
                BindingContext = new ChartsViewModel(cryptoName, "h1");
            }
            else
            {
                BindingContext = new ChartsViewModel(cryptoName, "d1");
            }
        }
    }
}