using Headphones.ViewModels;
using Xamarin.Forms;

namespace Headphones
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(Navigation);
        }
    }
}
