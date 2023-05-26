using SimpleFirstApp.Models;
using SimpleFirstApp.Services;
using SimpleFirstApp.Views.TabView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleFirstApp.ViewModels.TabViewModels
{
    public class MarketsViewModel : BaseViewModel
    {
        public MarketsViewModel()
        {
            Title = "Markets Page";
        }
        public MarketsViewModel(string id):this()
        {
            _ = LoadMarketsAsync(id);
        }
        public MarketsViewModel(string id, bool sortDescending) : this()
        {
            _ = LoadMarketsAsync(id, sortDescending);
        }
    }
}
