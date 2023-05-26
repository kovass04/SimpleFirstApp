using SimpleFirstApp.Models;
using SimpleFirstApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFirstApp.ViewModels
{
    public class CurrencyViewModel : BaseViewModel
    {
        public CurrencyViewModel()
        {
            Title = "Currency";
        }
        public CurrencyViewModel(string id,string id2):this()
        {
            _ = LoadAssetsAsync(id);
        }
    }
}
