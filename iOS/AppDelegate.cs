using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;

namespace ABLEV1.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : FormApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			Forms.Init ();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}

