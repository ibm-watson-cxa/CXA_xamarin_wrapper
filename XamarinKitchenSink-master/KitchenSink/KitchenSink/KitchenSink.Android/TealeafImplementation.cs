using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using KitchenSink;
using KitchenSink.Droid;

using Com.TL.Uic;
using Com.TL.Uic.Model;
using Com.Ibm.EO;
using XamarinCXA;

using System;
using System.Collections.Generic;
using Android.App;

[assembly: Dependency(typeof(TealeafImplementation))]
namespace KitchenSink.Droid
{
    public class TealeafImplementation : ITealeaf
    {
        private const string NAME = "XamarinCXA";
        private const int DEFAULT_LOG_LEVEL = 3;

        public TealeafImplementation() { }

        void ITealeaf.AddFocusAndRegister(View textView)
        {
            throw new System.NotImplementedException();
        }

        void ITealeaf.GetBooleanConfigItemForKey(string key, string moduleName)
        {
            bool result = (bool) EOCore.GetConfigItemBoolean(key, EOCore.GetLifecycleObject(moduleName));
        }

        string ITealeaf.GetName()
        {
            return NAME;
        }

        void ITealeaf.GetNumberItemForKey(int theDefault, string key, string moduleName)
        {
            int result = EOCore.GetConfigItemInt(key, EOCore.GetLifecycleObject(moduleName));
        }

        void ITealeaf.GetStringItemForKey(string theDefault, string key, string moduleName)
        {
            string result = EOCore.GetConfigItemString(key, EOCore.GetLifecycleObject(moduleName));
        }

        void ITealeaf.LogClickEvent(View view)
        {
            //try
            //{
            //    if (view is EditText)
            //    {

            //    }
            //    else
            //    {
            //        //Tealeaf.LogEvent(view, "click");
            //    }
            //}
        }

        void ITealeaf.LogCustomEvent(string eventName, Dictionary<string, string> map, int logLevel)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> entry in map)
            {
                dict.Add(entry.Key, (string)entry.Value);
            }

            Tealeaf.LogCustomEvent(eventName, dict, logLevel);
        }

        void ITealeaf.LogLocation()
        {
            try
            {
                Tealeaf.LogGeolocation(DEFAULT_LOG_LEVEL);
            }
            catch (Exception e)
            {

            }
        }

        void ITealeaf.LogLocationUpdateWithLatitude(double lat, double lng, int logLevel)
        {
            // TODO: NOT SUPPORTED
        }

        void ITealeaf.LogScreenLayout(string logicalPageName)
        {
            try
            {
                var currentActivity = (Activity)Android.App.Application.Context;
                Tealeaf.LogScreenLayout(currentActivity, logicalPageName);
            }
            catch (Exception e)
            {

            }
        }

        void ITealeaf.LogScreenLayoutWithDelay(string logicalPageName, int delay)
        {
            try
            {
                var currentActivity = (Activity)Android.App.Application.Context;
                Tealeaf.LogScreenLayout(currentActivity, logicalPageName, delay < 0 ? 0 : delay);
            }
            catch (Exception e)
            {

            }
        }

        void ITealeaf.LogScreenViewContextLoad(string logicalPageName, string referrer)
        {
            try
            {
                var currentActivity = (Activity)Android.App.Application.Context;
                Tealeaf.LogScreenview(currentActivity, logicalPageName, ScreenviewType.Load, referrer);
            }
            catch (Exception e)
            {

            }
        }

        void ITealeaf.LogScreenViewContextUnLoad(string logicalPageName, string referrer)
        {
            try
            {
                var currentActivity = (Activity)Android.App.Application.Context;
                Tealeaf.LogScreenview(currentActivity, logicalPageName, ScreenviewType.Unload, referrer);
            }
            catch (Exception e)
            {

            }
        }

        void ITealeaf.SetConfigItem(string key, object value, string moduleName)
        {
            string strValue = (value == null) ? "true" : "false";
            bool result = (bool) EOCore.UpdateConfig(key, strValue, EOCore.GetLifecycleObject(moduleName));
        }

        //void ITealeaf.updateResult(object result)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
