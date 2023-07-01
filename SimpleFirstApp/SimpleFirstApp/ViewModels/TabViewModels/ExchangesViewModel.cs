

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
