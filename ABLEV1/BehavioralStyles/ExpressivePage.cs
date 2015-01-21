using System;

using Xamarin.Forms;

namespace ABLEV1
{
	public class ExpressivePage : ContentPage
	{
		public ExpressivePage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Expressive Page" }
				}
			};
		}
	}
}


