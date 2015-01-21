using System;

using Xamarin.Forms;

namespace ABLEV1
{
	public class DriverPage : ContentPage
	{
		public DriverPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Driver Page" }
				}
			};
		}
	}
}


