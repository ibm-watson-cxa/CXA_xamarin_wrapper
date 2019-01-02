using System;
using System.Collections.Generic;

namespace XamarinCXA
{
    public interface ITealeaf
    {
        // Get this interface name
        string GetName();


        /**
         * @param readableMap
         * @param moduleName
         * @param promise
         */
        // void updateConfigWithData(readonly ReadableMap readableMap, readonly String moduleName, readonly Promise promise)
        //{
        //    // TODO: Is it required for Android?
        //    //updateResult(null, promise);
        //}

        /**
         * Gets the module's configuration item from AdvancedConfig.json or BasicConfig.properties that matches the specified key as a BOOL value.
         *
         * @param key        Key value.
         * @param moduleName The class name of the module's EOLifecycleObject for which the configuration item is referencing.
         * @param promise    Javascript Promise interface.
         */

        void GetBooleanConfigItemForKey(string key, string moduleName);

        /**
         * Gets the module's configuration item from AdvancedConfig.json or BasicConfig.properties that matches the specified key.
         *
         * @param theDefault In case no value if found, use this value as default.
         * @param key        Key.
         * @param moduleName The class name of the module's EOLifecycleObject for which the configuration item is referencing.
         * @param promise    Javascript Promise interface.
         */

        void GetStringItemForKey(string theDefault, string key, string moduleName);

        /**
         * Gets the module's configuration item from AdvancedConfig.json or BasicConfig.properties that matches the specified key.
         *
         * @param theDefault In case no value if found, use this value as default.
         * @param key        Map Key.
         * @param moduleName The class name of the module's EOLifecycleObject for which the configuration item is referencing.
         */

        void GetNumberItemForKey(int theDefault, String key, String moduleName);

        /**
         * Sets the module's configuration item from AdvancedConfig.json or BasicConfig.properties that matches the specified key.
         *
         * @param key        Map Key.
         * @param value      Map Value.
         * @param moduleName The class name of the module's EOLifecycleObject for which the configuration item is referencing.
         * @param promise    Javascript Promise interface.
         */

        void SetConfigItem(String key, Object value, String moduleName);

        /**
         * Log Custom event.
         *
         * @param eventName   The name of the event to be logged this will appear in the posted json
         * @param map React-Native compatible map type.
         * @param logLevel    Set a custom log level to the event. This will override the configured log level for that event.
         * @param promise     Javascript Promise interface.
         */

        void LogCustomEvent(String eventName, Dictionary<string, string> map, int logLevel);
        //{
        //    HashMap<string, string> map = new HashMap<>();

        //    // Convert to conform with React-Native MAP type
        //    for (Map.Entry<string, object> entry : readableMap.toHashMap().entrySet())
        //    {
        //        map.put(entry.getKey(), (string)entry.getValue());
        //    }

        //    boolean result = Tealeaf.logCustomEvent(eventName, map, logLevel);
        //    updateResult(result, promise);
        //}

        /**
         * Log Current Screen Layout
         *
         * @param logicalPageName Page name or title e.g. "Login View Controller"; Must not be empty.
         * @param promise         Javascript Promise interface.
         */

        void LogScreenLayout(String logicalPageName);
        //{
        //    boolean result = Tealeaf.logScreenLayout(getCurrentActivity(), logicalPageName, 500);
        //    updateResult(result, promise);
        //}

        /**
         * Log Current Screen Layout
         *
         * @param logicalPageName Page name or title e.g. "Login View Controller"; Must not be empty.
         * @param delay           Number of seconds to wait before logging the view.
         * @param promise         Javascript Promise interface.
         */
        void LogScreenLayoutWithDelay(String logicalPageName, int delay);
        //{
        //    boolean result = Tealeaf.logScreenLayout(getCurrentActivity(), logicalPageName, delay < 0 ? 500 : delay);
        //    updateResult(result, promise);
        //}

        /**
         * Log GeoLocation.  Below permission is need in the androidmanifest.xml file.
         * <uses-permission android:name="android.permission.ACCESS_FINE_LOCATION" />
         *
         */

        void LogLocation();
        //{
        //    boolean result = Tealeaf.logGeolocation(EOMonitoringLevel.kEOMonitoringLevelInfo.getValue());
        //    updateResult(result, promise);
        //}

        /**
         * Requests that the framework logs the location information. This is not logged automatically to
         * avoid making unnecessary location updates and to protect the privacy of your application's users
         * by ensuring that location is reported only when the app has some other reason to request it.
         * Your application must include the Core Location framework.
         *
         * @param lat      The geographic latitude of the user.
         * @param lng      The geographic longitude of the user.
         * @param logLevel The monitoring level of the event.
         * @param promise  Javascript Promise interface.
         */

        void LogLocationUpdateWithLatitude(double lat, double lng, int logLevel);
        //{
        //    boolean result = Tealeaf.logLocationUpdateEventWithLatitude(lat, lng, logLevel);
        //    updateResult(result, promise);
        //}

        /**
         * Add focus listener to handle EditText UI control.
         *
         * @param textView Input TextView.
         * @param activity Current activity.
         */
        void AddFocusAndRegister(Xamarin.Forms.View textView);
        //    {
        //        textView.setOnFocusChangeListener(new View.OnFocusChangeListener() {
        //        @Override
        //         void onFocusChange(View v, boolean hasFocus)
        //        {
        //            if (hasFocus)
        //            {
        //                InputMethodManager imm = (InputMethodManager)v.getContext().getSystemService(Context.INPUT_METHOD_SERVICE);
        //                imm.showSoftInput(v, InputMethodManager.SHOW_FORCED);

        //                KeyboardView keyboardView = new KeyboardView(v.getContext().getApplicationContext(), null);
        //                Tealeaf.logEvent(keyboardView, Tealeaf.TLF_UI_KEYBOARD_DID_SHOW_NOTIFICATION);
        //                Tealeaf.logEvent(v, Tealeaf.TLF_ON_FOCUS_CHANGE_IN);
        //            }
        //            else
        //            {
        //                com.tl.uic.Tealeaf.logEvent(v, com.tl.uic.Tealeaf.TLF_ON_FOCUS_CHANGE_OUT);
        //                InputMethodManager imm = (InputMethodManager)v.getContext().getSystemService(Context.INPUT_METHOD_SERVICE);
        //                imm.hideSoftInputFromWindow(v.getWindowToken(), 0);

        //                KeyboardView keyboardView = new KeyboardView(v.getContext().getApplicationContext(), null);
        //                Tealeaf.logEvent(keyboardView, Tealeaf.TLF_UI_KEYBOARD_DID_HIDE_NOTIFICATION);
        //            }
        //        }
        //    });

        //    Tealeaf.registerFormField(textView, activity);
        //}

        /**
         * Requests that the framework logs the click events on any UIControl or View. Click event is a
         * normalized form of touch up inside event.
         *
         * @param targetViewId A valid native View Id for lookup
         * @param promise      Javascript Promise interface.
         */
        void LogClickEvent(Xamarin.Forms.View view);

        //    void logClickEvent(int targetViewId)
        //    {
        //        try
        //        {
        //            ReactApplicationContext context = getReactApplicationContext();
        //            // Add UI-block so we can get a valid reference to the map-view
        //            UIManagerModule uiManager = context.getNativeModule(UIManagerModule.class);

        //            uiManager.addUIBlock(new UIBlock()
        //    {
        //         void execute(NativeViewHierarchyManager nvhm)
        //        {
        //            View view = nvhm.resolveView(targetViewId);

        //            if (view == null)
        //            {
        //                updateResult(null, promise);
        //            }
        //            else
        //            {
        //                //
        //                if (view instanceof EditText) {
        //            addFocusAndRegister((EditText)view, getCurrentActivity());
        //        } else {
        //            Tealeaf.logEvent(view, "click");
        //        }
        //        updateResult(true, promise);
        //    }
        //}
        //        });
        //    } catch (Exception e) {
        //        updateResult(e, promise);
        //    }
        //}

        /**
         * Requests that the framework logs an screen load event.
         *
         * @param logicalPageName Page name or title e.g. "Login View Controller"; Must not be empty.
         * @param referrer        Page name or title that loads logicalPageName. Could be empty.
         * @param promise         Javascript Promise interface.
         */

        void LogScreenViewContextLoad(String logicalPageName, String referrer);
        //{
        //    boolean result = Tealeaf.logScreenview(getCurrentActivity(), logicalPageName, ScreenviewType.LOAD, referrer);
        //    updateResult(result, promise);
        //}

        /**
         * Requests that the framework logs an screen unload event.
         *
         * @param logicalPageName Page name or title e.g. "Login View Controller"; Must not be empty.
         * @param referrer        Page name or title that loads logicalPageName. Could be empty.
         * @param promise         Javascript Promise interface.
         */

        void LogScreenViewContextUnLoad(String logicalPageName, String referrer);
        //{
        //    boolean result = Tealeaf.logScreenview(getCurrentActivity(), logicalPageName, ScreenviewType.UNLOAD, referrer);
        //    updateResult(result, promise);
        //}

        /**
         * Helper function for Promise result
         *
         * @param result  Result from Tealeaf API call.
         * @param promise Javascript Promise interface.
         */
        //private void updateResult(object result)
        //{
        //    if ((result != null) && ((bool)result) == true)
        //    {
        //        promise.resolve(result);
        //    }
        //    else
        //    {
        //        promise.reject("", "", new Throwable());
        //    }
        //}
    }
}
