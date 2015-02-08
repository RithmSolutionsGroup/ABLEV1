using System;
using Xamarin.Forms;

namespace ABLEV1
{
	public class JustLearnPage : ContentPage
	{

		Func<View> portraitView;
		Func<View> landscapeView;

		public JustLearnPage ()
		{
			BackgroundColor = Color.Gray;

			var qCard1 = new QCardView {
				frontLabel = "Hello",
				backLabel = "There",
			};

			var qCard2 = new QCardView {
				frontLabel = "Hello",
				backLabel = "There",
			};

			var qCard3 = new QCardView {
				frontLabel = "Hello",
				backLabel = "There",
			};

			var qCard4 = new QCardView {
				frontLabel = "Hello",
				backLabel = "There",
			};

			portraitView = () => new StackLayout {
				Spacing = 25,
				Padding = new Thickness(25, 25, 25, 25),
				Children = {
					qCard1,
					qCard2,
					qCard3,
					qCard4,

				},
			};

			landscapeView = () => new Grid {
				Children = {

				},
				BackgroundColor = Color.White,
				VerticalOptions = LayoutOptions.FillAndExpand,
				//4 Rows for the Logo, Buttons, and Extra Space at the bottom (0, 1, 2, 3)
				RowDefinitions = {
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (.5, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (3, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (1.5, GridUnitType.Star) }
				},
				//2 Columns for the Buttons (0, 1)
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				}

			};
		
			SizeChanged += (sender, e) => Content = App.isPortrait(this) ? portraitView() : landscapeView();
		}

		protected override void OnSizeAllocated (double width, double height) { base.OnSizeAllocated (width, height); }
	}
}


