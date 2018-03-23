﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;

namespace CdaMobileApp.Droid
{
	[Activity(Label = "@string/app_name",
              Icon = "@mipmap/ic_launcher",
              Theme = "@style/SplashTheme",
              MainLauncher = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

			StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
        }
    }
}