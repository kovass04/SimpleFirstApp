using SimpleFirstApp.Models;
using SimpleFirstApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFirstApp.ViewModels.TabViewModels
{
    public class ExchangesViewModel : BaseViewModel
    {
        public ExchangesViewModel()
        {
            Title = "Markets Page";
            _ = LoadExchangesAsync();
        }
    }
}
