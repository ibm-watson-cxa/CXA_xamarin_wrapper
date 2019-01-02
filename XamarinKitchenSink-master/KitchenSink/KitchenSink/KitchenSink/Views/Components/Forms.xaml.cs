namespace KitchenSink.Views.Components
{
    using Xamarin.Forms;
    using XamarinCXA;

    public partial class Forms : ContentPage
    {
        public Forms()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DependencyService.Get<ITealeaf>().LogScreenLayout("Forms View");
        }
    }
}
