namespace KitchenSink.Views.Layouts
{
    using Xamarin.Forms;

    public partial class RelativeLayout : ContentPage
    {
        public RelativeLayout()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DependencyService.Get<XamarinCXA.ITealeaf>().LogScreenLayout("RelativeLayout View");
        }
    }
}
