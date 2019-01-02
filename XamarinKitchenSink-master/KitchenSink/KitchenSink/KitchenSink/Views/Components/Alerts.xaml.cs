namespace KitchenSink.Views.Components
{
    using Xamarin.Forms;
    using XamarinCXA;

    public partial class Alerts : ContentPage
    {
        public Alerts()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            DependencyService.Get<ITealeaf>().LogScreenLayout("Alerts View");
        }

        void OnButtonClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            DependencyService.Get<ITealeaf>().LogClickEvent(button);
        }
    }
}
