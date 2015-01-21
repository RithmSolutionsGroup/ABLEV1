using System;

using Xamarin.Forms;

namespace ABLEV1
{
	public class AnalyticalPage : ContentPage
	{
		public AnalyticalPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Analytical Page" }
				}
			};
		}
	}
}


