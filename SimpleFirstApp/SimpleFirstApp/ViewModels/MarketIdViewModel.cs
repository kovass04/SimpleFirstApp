using SimpleFirstApp.Models;
using SimpleFirstApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFirstApp.ViewModels
{
    public class MarketIdViewModel : BaseViewModel
    {
        public MarketIdViewModel(string id)
        {
            Title = id;
        }
    }
}
