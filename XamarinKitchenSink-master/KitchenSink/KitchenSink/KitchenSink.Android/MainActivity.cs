using System;

using Android.App;
using Android.Content.PM;
using Android.Views;
using Android.OS;

using Com.TL.Uic;

using Com.Ibm.EO;

using KitchenSink.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(MainActivity))]
namespace KitchenSink.Droid
{
    [Activity( Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        MainActivity GetCurrentActivity()
        {
            return (MainActivity) Forms.Context;
        }

        protected override void OnResume()
        {
            base.OnResume();
            Tealeaf.LogScreenLayout(GetCurrentActivity(), "MainActivity", 500);
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            Tealeaf tl = new Tealeaf(this.Application);
            Tealeaf.Enable();

            string prodqa = "https://prodqa-collector.tealeaf.ibmcloud.com/collector/collectorPost";
            string appKey = "93b07040e94f4d979ccded272b3a15c1";
            EOCore.UpdateConfig("PostMessageUrl", prodqa, EOCore.GetLifecycleObject("Tealeaf"));
            EOCore.UpdateConfig("AppKey", appKey, EOCore.GetLifecycleObject("Tealeaf"));
            EOCore.UpdateConfig("DisableAutoInstrumentation", "true", EOCore.GetLifecycleObject("Tealeaf"));
        }

        public override Boolean DispatchTouchEvent(MotionEvent e)
        {
            Tealeaf.DispatchTouchEvent(this, e);
            return base.DispatchTouchEvent(e);
        }

        //void ITealeaf.LogScreenLayout(string text)
        //{
        //    //Android.App.Activity act = new Android.App.Activity();
        //    //act.SetContentView(ConvertToNativeView(page));
        //    //var currentContext = Android.App.Application.Context;
        //    Tealeaf.LogScreenLayout(GetCurrentActivity(), text, 500);
        //}


        //void ITealeaf.LogClickEvent(Xamarin.Forms.View view, string text)
        //{
        //    var renderer = Platform.CreateRendererWithContext(view, Forms.Context);
        //    Platform.SetRenderer(view, renderer);

        //    Tealeaf.LogEvent(renderer.View, text);
        //}
    }
}

