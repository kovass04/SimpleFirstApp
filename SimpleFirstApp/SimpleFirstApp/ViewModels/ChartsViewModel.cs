using SimpleFirstApp.Models;
using SimpleFirstApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFirstApp.ViewModels
{
    public class ChartsViewModel : BaseViewModel
    {
        private readonly DataServices _Services;
        private List<Charts> _charts;
        public List<Charts> Charts
        {
            get => _charts;
            set
            {
                SetProperty(ref _charts, value);
            }
        }
        public ChartsViewModel(string i)
        {
            string a = "bitcoin";
            Title = "Markets Page";
            _Services = new DataServices();
            LoadChartsAsync(i);

        }
        private async Task LoadChartsAsync(string i)
        {
            var charts = await _Services.GetChartsAsync(i);
            Charts = new List<Charts>(charts.data);
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }
    }
}
