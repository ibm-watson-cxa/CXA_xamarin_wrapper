namespace KitchenSink.Views.Layouts
{
    using Xamarin.Forms;

    public partial class StackLayout : ContentPage
    {
        public StackLayout()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DependencyService.Get<XamarinCXA.ITealeaf>().LogScreenLayout("StackLayout View");
        }
    }
}
