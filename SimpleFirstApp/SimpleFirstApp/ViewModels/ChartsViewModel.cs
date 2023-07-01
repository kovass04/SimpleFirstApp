using Syncfusion.XForms.Buttons;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace SimpleFirstApp.ViewModels
{
    public class ChartsViewModel : BaseViewModel
    {
        private ObservableCollection<SfSegmentItem> imageTextCollection;
        public ObservableCollection<SfSegmentItem> ImageTextCollection
        {
            get { return imageTextCollection; }
            set { imageTextCollection = value; }
        }
        public ChartsViewModel()
        {
            Title = "Markets Page";
            imageTextCollection = new ObservableCollection<SfSegmentItem>
        {
            new SfSegmentItem(){IconFont = "1", FontIconFontColor=Color.FromHex("#FFFFFF"), FontColor=Color.FromHex("#FFFFFF"), Text = "Day"},
            new SfSegmentItem(){IconFont = "1", FontIconFontColor=Color.FromHex("#FFFFFF"), FontColor=Color.FromHex("#FFFFFF"), Text = "Mounth"},
            new SfSegmentItem(){IconFont = "1", FontIconFontColor=Color.FromHex("#FFFFFF"), FontColor=Color.FromHex("#FFFFFF"), Text = "Year"} };
        }
        public ChartsViewModel(string cryptoName, string date) : this()
        {
            _ = LoadChartsAsync(cryptoName, date);
        }
    }
}
