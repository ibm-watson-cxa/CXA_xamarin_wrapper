﻿namespace KitchenSink.Views.Components
{
    using Xamarin.Forms;
    using XamarinCXA;

    public partial class Modal : ContentPage
    {
        public Modal()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DependencyService.Get<ITealeaf>().LogScreenLayout("Modal View");
        }
    }
}
