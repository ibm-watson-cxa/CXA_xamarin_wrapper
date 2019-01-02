
using Com.TL.Uic;

using Com.Ibm.EO;

namespace KitchenSink.Views
{
    using Xamarin.Forms;
    using XamarinCXA;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DependencyService.Get<ITealeaf>().LogScreenLayout("Main Page View");
        }
    }
}
