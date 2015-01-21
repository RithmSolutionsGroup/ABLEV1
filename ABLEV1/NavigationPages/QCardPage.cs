using System;

using Xamarin.Forms;

namespace ABLEV1
{
	public class QCardPage : ContentPage
	{
		public QCardPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Q Card Page" }
				}
			};
		}
	}
}


