using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace EltonTest.Droid
{
	[Activity(Label = "EltonTest", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			//TabLayoutResource = Resource.Layout.Tabbar;
			//ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
			Forms9Patch.Droid.Settings.LicenseKey = "XFFE-LA3R-FWLX-BBWL-5D8Y-3GXG-72GY-4EH8-GXTP-W7AQ-L8Q2-A7FX-B4DP";

			LoadApplication(new App());
		}
	}
}
