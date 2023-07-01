using System.Threading.Tasks;

namespace SimpleFirstApp.ViewModels.TabViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public Task Init { get; }
        public HomeViewModel()
        {
            Title = "Homepage";
            Init = Initialize();
        }
        private async Task Initialize()
        {
            await LoadAssetsAsync();
        }
    }
}
