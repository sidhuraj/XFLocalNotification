﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace NotificationSample.Droid
{
    [Activity(Label = "NotificationSample", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            //Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            //Handle Push Notifications Concepts: add Below 5  Line//
            //bool flag = false;
            //if (Intent.Extras != null)
            //{
            //    flag = true;
            //}
            LoadApplication(new App());
            //Handle Push Notifications Concepts: add Below 1 Line+method also//
            //IsPlayServicesAvailable();
        }
        //        public bool IsPlayServicesAvailable()
        //        {
        //            int resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
        //            if (resultCode != ConnectionResult.Success)
        //            {

        //                if (GoogleApiAvailability.Instance.IsUserResolvableError(resultCode))
        //                {
        //                    //msgText.Text = GoogleApiAvailability.Instance.GetErrorString(resultCode);
        //                }

        //                else
        //                {
        //                    // msgText.Text = "This device is not supported";
        //                    Finish();
        //                }
        //                return false;
        //            }
        //            else
        //            {
        //                // do whatever if play service is not available
        //                //msgText.Text = "Google Play Services is available.";
        //                return true;
        //            }
        //        }
        //    }
        //}
        //public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        //{
        //    Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        //    base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        //}
    }
}