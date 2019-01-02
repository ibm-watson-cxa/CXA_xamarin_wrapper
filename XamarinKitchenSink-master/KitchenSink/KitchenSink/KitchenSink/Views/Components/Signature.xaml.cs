namespace KitchenSink.Views.Components
{
    using Xamarin.Forms;
    using XamarinCXA;

    public partial class Signature : ContentPage
    {
        public Signature()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DependencyService.Get<ITealeaf>().LogScreenLayout("Signature View");
        }
    }
}
