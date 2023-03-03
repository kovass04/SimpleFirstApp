using SimpleFirstApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SimpleFirstApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}