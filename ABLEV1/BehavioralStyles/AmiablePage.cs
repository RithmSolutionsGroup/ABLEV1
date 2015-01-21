using System;

using Xamarin.Forms;

namespace ABLEV1
{
	public class AmiablePage : ContentPage
	{
		public AmiablePage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Amiable Page" }
				}
			};
		}
	}
}


