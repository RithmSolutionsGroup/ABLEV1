using System;

using Xamarin.Forms;

namespace ABLEV1
{
	public class RatingsFeedbackPage : ContentPage
	{
		public RatingsFeedbackPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Ratings/Feedback Page" }
				}
			};
		}
	}
}


