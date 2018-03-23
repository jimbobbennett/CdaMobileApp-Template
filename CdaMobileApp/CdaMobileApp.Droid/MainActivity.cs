using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace CdaMobileApp.Droid
{
	[Activity(Label = "@string/app_name", 
	          Icon = "@mipmap/ic_launcher", 
	          Theme = "@style/MainTheme", 
	          MainLauncher = false, 
	          ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
    }
}

