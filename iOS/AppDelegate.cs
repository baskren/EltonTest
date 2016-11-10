// /*******************************************************************
//  *
//  * AppDelegate.cs copyright 2016 ben, 42nd Parallel - ALL RIGHTS RESERVED.
//  *
//  *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace EltonTest.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			Forms9Patch.iOS.Settings.LicenseKey = "XFFE-LA3R-FWLX-BBWL-5D8Y-3GXG-72GY-4EH8-GXTP-W7AQ-L8Q2-A7FX-B4DP";

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
