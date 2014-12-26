using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace ABLEV1
{
	public class MainScreen : ContentPage
	{
		public MainScreen ()
		{
			Title = "MainScreen";

			Grid grid = new Grid {
				BackgroundColor = Color.White,
				VerticalOptions = LayoutOptions.FillAndExpand,
				RowDefinitions = {
					new RowDefinition { Height = new GridLength (1.5, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (2, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (2, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) }
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				}
			};

			grid.Children.Add (
				new StackLayout {
					Orientation = StackOrientation.Vertical,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
					Children = {
						new StackLayout {
							Orientation = StackOrientation.Horizontal,				
							Children = {
								new Image{
									Source = ImageSource.FromResource("ABLEV1.Images.Logos.ABLE-LOGO-1.png")
								},
								new Image{
									Source = ImageSource.FromResource("ABLEV1.Images.Logos.ABLE-LOGO-2.png")
								},
							}
						}
					},
					BackgroundColor = Color.White,

				}, 0, 2, 0, 1);

			grid.Children.Add (
				new StackLayout {
					Orientation = StackOrientation.Vertical,
					Children = {

					},
					BackgroundColor = Color.Red,

				}, 0, 1, 1, 2);

			grid.Children.Add (
				new StackLayout {
					Orientation = StackOrientation.Vertical,
					Children = {

					},
					BackgroundColor = Color.Blue,
				}, 1, 2, 1, 2);

			grid.Children.Add (
				new StackLayout {
					Orientation = StackOrientation.Vertical,
					Children = {

					},
					BackgroundColor = Color.Green,
				}, 0, 1, 2, 3);

			grid.Children.Add (
				new StackLayout {
					Orientation = StackOrientation.Vertical,
					Children = {

					},
					BackgroundColor = Color.Fuchsia,
				}, 1, 2, 2, 3);

			BackgroundColor = Color.White;

			Content = grid;


		}


	}
}

