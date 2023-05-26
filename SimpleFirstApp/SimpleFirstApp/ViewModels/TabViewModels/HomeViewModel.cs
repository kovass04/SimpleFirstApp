using SimpleFirstApp.Models;
using SimpleFirstApp.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Syncfusion.XForms.Buttons;

namespace SimpleFirstApp.ViewModels.TabViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        
        public HomeViewModel()
        {
            Title = "Homepage";
            _ = LoadAssetsAsync();
        }
    }
}
