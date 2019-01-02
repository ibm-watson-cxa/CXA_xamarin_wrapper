namespace KitchenSink.Views.Components
{
    using Xamarin.Forms;
    using XamarinCXA;

    public partial class ModalDetails : ContentPage
    {
        public ModalDetails()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DependencyService.Get<ITealeaf>().LogScreenLayout("Modal Details View");
        }
    }
}
