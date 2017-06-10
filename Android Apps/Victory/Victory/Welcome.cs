
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Victory
{
    [Activity(Label = "Welcome")]
    public class Welcome : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Welcome_Page);

            Button Logout = FindViewById<Button>(Resource.Id.Logout);
            Logout.Click+=  delegate {
                StartActivity(typeof(MainActivity));
            };
            // Create your application here
        }

      
    }
}
