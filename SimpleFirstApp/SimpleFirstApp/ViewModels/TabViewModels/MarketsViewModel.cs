

namespace SimpleFirstApp.ViewModels.TabViewModels
{
    public class MarketsViewModel : BaseViewModel
    {
        public MarketsViewModel()
        {
            Title = "Markets Page";
        }
        public MarketsViewModel(string crytoName):this()
        {
            _ = LoadMarketsAsync(crytoName);
        }
        public MarketsViewModel(string crytoName, bool sortDescending) : this()
        {
            _ = LoadMarketsAsync(crytoName, sortDescending);
        }
    }
}
