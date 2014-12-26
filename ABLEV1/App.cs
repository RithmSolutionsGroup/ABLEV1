using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace ABLEV1
{
	public class App : Application
	{
		public App()
		{
			MainPage = new ContentPage
			{
				Content = new Label
				{
					Text = "Hello, Forms !",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
			};
		}

		protected override void OnResume()
		{
			Debug.WriteLine("OnResume");
			base.OnResume();
		}

		protected override void OnSleep()
		{
			Debug.WriteLine("OnSleep");
			base.OnSleep();
		}

		protected override void OnStart()
		{
			Debug.WriteLine("OnStart");
			base.OnStart();
		}
	}
}

