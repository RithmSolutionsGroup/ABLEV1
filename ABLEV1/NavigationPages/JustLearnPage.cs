using System;

using Xamarin.Forms;

namespace ABLEV1
{
	public class JustLearnPage : ContentPage
	{
		public JustLearnPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Just Learn Page" }
				}
			};
		}
	}
}


