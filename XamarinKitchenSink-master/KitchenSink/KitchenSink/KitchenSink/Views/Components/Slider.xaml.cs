namespace KitchenSink.Views.Components
{
    using Xamarin.Forms;
    using XamarinCXA;

    public partial class Slider : ContentPage
    {
        public Slider()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DependencyService.Get<ITealeaf>().LogScreenLayout("Slider View");
        }
    }
}
