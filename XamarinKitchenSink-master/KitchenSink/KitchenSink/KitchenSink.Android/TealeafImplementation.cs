using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using KitchenSink;
using KitchenSink.Droid;

using Com.TL.Uic;
using XamarinCXA;
using System.Collections.Generic;

[assembly: Dependency(typeof(TealeafImplementation))]
namespace KitchenSink.Droid
{
    public class TealeafImplementation : ITealeaf
    {

        public TealeafImplementation() { }

        void ITealeaf.AddFocusAndRegister(View textView)
        {
            throw new System.NotImplementedException();
        }

        void ITealeaf.GetBooleanConfigItemForKey(string key, string moduleName)
        {
            throw new System.NotImplementedException();
        }

        string ITealeaf.GetName()
        {
            throw new System.NotImplementedException();
        }

        void ITealeaf.GetNumberItemForKey(int theDefault, string key, string moduleName)
        {
            throw new System.NotImplementedException();
        }

        void ITealeaf.GetStringItemForKey(string theDefault, string key, string moduleName)
        {
            throw new System.NotImplementedException();
        }

        void ITealeaf.LogClickEvent(View view)
        {
            throw new System.NotImplementedException();
        }

        void ITealeaf.LogCustomEvent(string eventName, Dictionary<string, string> map, int logLevel)
        {
            throw new System.NotImplementedException();
        }

        void ITealeaf.LogLocation()
        {
            throw new System.NotImplementedException();
        }

        void ITealeaf.LogLocationUpdateWithLatitude(double lat, double lng, int logLevel)
        {
            throw new System.NotImplementedException();
        }

        void ITealeaf.LogScreenLayout(string logicalPageName)
        {
            throw new System.NotImplementedException();
        }

        void ITealeaf.LogScreenLayoutWithDelay(string logicalPageName, int delay)
        {
            throw new System.NotImplementedException();
        }

        void ITealeaf.LogScreenViewContextLoad(string logicalPageName, string referrer)
        {
            throw new System.NotImplementedException();
        }

        void ITealeaf.LogScreenViewContextUnLoad(string logicalPageName, string referrer)
        {
            throw new System.NotImplementedException();
        }

        void ITealeaf.SetConfigItem(string key, object value, string moduleName)
        {
            throw new System.NotImplementedException();
        }

        //void ITealeaf.updateResult(object result)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void LogScreenLayout(string text)
        //{
        //    Tealeaf.LogScreenLayout(this, text, 500);
        //}
    }
}
