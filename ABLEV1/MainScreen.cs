using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ABLEV1
{
	public class MainScreen : ContentPage
	{

		private void OnLayoutClicked ()
		{

		}

		public MainScreen ()
		{
			Title = "MainScreen";

			//Grid Definitions
			Grid grid = new Grid {
				BackgroundColor = Color.White,
				VerticalOptions = LayoutOptions.FillAndExpand,
				//4 Rows for the Logo, Buttons, and Extra Space at the bottom (0, 1, 2, 3)
				RowDefinitions = {
					new RowDefinition { Height = new GridLength (1.5, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (2, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (2, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) }
				},
				//2 Columns for the Buttons (0, 1)
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				}
			};

			//Adding the Logo to the Grid
			grid.Children.Add (
				//StackLayout to Hold everything
				new StackLayout {
					Orientation = StackOrientation.Vertical,
					VerticalOptions = LayoutOptions.FillAndExpand,
					HorizontalOptions = LayoutOptions.FillAndExpand,
					BackgroundColor = Color.White,
					Children = {
						//StackLayout to hold the two images that make up the Logo
						new StackLayout {
							VerticalOptions = LayoutOptions.CenterAndExpand,
							HorizontalOptions = LayoutOptions.CenterAndExpand,
							Orientation = StackOrientation.Horizontal,				
							Children = {
								//First Image (ABLE Logo)
								new Image {
									Source = ImageSource.FromResource ("ABLEV1.Images.Logos.ABLE-LOGO-1.png"),
								},
								//Second Image (ABLE Name + SubTitle)
								new Image {
									Source = ImageSource.FromResource ("ABLEV1.Images.Logos.ABLE-LOGO-2.png")
								},
							}
						}
					},
					//Logo Column Starts at 0 and Ends at 2
					//Logo Row Starts at 0 and Ends at 1
				}, 0, 2, 0, 1);

			//Adding the Just Learn Button to the Grid
			grid.Children.Add (
				//StackLayout to Hold everything
				new StackLayout {
					Orientation = StackOrientation.Vertical,
					//GestureRecognizer to perform Button Presses on Icon
					GestureRecognizers = {
						new TapGestureRecognizer {
							Command = new Command (() => Debug.WriteLine ("Just Learn")),
						}
					},
					//Adding the Image and Label for the Button
					Children = {
						//Creates the Image, and Adds it's Source (Found in Images/Page1)
						new Image {
							Source = ImageSource.FromResource ("ABLEV1.Images.Page1.JustLearn-Icon.png"),
							VerticalOptions = LayoutOptions.FillAndExpand,
							HorizontalOptions = LayoutOptions.FillAndExpand,
						},
						//Creates the Label, and Adds it's Font Settings (Large Sized and Bold)
						new Label {
							HorizontalOptions = LayoutOptions.CenterAndExpand,
							Text = "Just Learn",
							TextColor = Color.Black,
							Font = Font.SystemFontOfSize (NamedSize.Large)
								.WithAttributes (FontAttributes.Bold),
						}
					},
					//Just Learn Column Starts at 0 and Ends at 1
					//Just Learn Row Starts at 1 and Ends at 2
				}, 0, 1, 1, 2);

			//Adding the Dealings Button to the Grid
			grid.Children.Add (
				//StackLayout to Hold everything
				new StackLayout {
					Orientation = StackOrientation.Vertical,
					//GestureRecognizer to perform Button Presses on Icon
					GestureRecognizers = {
						new TapGestureRecognizer {
							Command = new Command (() => Debug.WriteLine ("Dealings")),
						}
					},
					//Adding the Image and Label for the Button
					Children = {
						//Creates the Image, and Adds it's Source (Found in Images/Page1)
						new Image {
							Source = ImageSource.FromResource ("ABLEV1.Images.Page1.Dealings-Icon.png"),
							VerticalOptions = LayoutOptions.FillAndExpand,
							HorizontalOptions = LayoutOptions.FillAndExpand,
						},
						//Creates the Label, and Adds it's Font Settings (Large Sized and Bold)
						new Label {
							HorizontalOptions = LayoutOptions.CenterAndExpand,
							Text = "Dealings",
							TextColor = Color.Black,
							Font = Font.SystemFontOfSize (NamedSize.Large)
								.WithAttributes (FontAttributes.Bold),
						}
					},
					//Dealings Column Starts at 1 and Ends at 2
					//Dealings Row Starts at 1 and Ends at 2
				}, 1, 2, 1, 2);

			//Adding the Q Card Button to the Grid
			grid.Children.Add (
				//StackLayout to Hold everything
				new StackLayout {
					Orientation = StackOrientation.Vertical,					
					//GestureRecognizer to perform Button Presses on Icon
					GestureRecognizers = {
						new TapGestureRecognizer {
							Command = new Command (() => Debug.WriteLine ("Q Card")),
						}
					},
					//Adding the Image and Label for the Button
					Children = {
						//Creates the Image, and Adds it's Source (Found in Images/Page1)
						new Image {
							Source = ImageSource.FromResource ("ABLEV1.Images.Page1.QCard-Icon.png"),
							VerticalOptions = LayoutOptions.FillAndExpand,
							HorizontalOptions = LayoutOptions.FillAndExpand,
						},
						//Creates the Label, and Adds it's Font Settings (Large Sized and Bold)
						new Label {
							HorizontalOptions = LayoutOptions.CenterAndExpand,
							Text = "Q Card",
							TextColor = Color.Black,
							Font = Font.SystemFontOfSize (NamedSize.Large)
								.WithAttributes (FontAttributes.Bold),
						}
					},
					//Q Card Column Starts at 0 and Ends at 1
					//Q Card Row Starts at 2 and Ends at 3
				}, 0, 1, 2, 3);

			//Adding the Ratings/Feedback Button to the Grid
			grid.Children.Add (
				//StackLayout to Hold everything
				new StackLayout {
					Orientation = StackOrientation.Vertical,
					//GestureRecognizer to perform Button Presses on Icon
					GestureRecognizers = {
						new TapGestureRecognizer {
							Command = new Command (() => Debug.WriteLine ("Ratings/Feedback")),
						}
					},
					//Adding the Image and Label for the Button
					Children = {
						//Creates the Image, and Adds it's Source (Found in Images/Page1)
						new Image {
							Source = ImageSource.FromResource ("ABLEV1.Images.Page1.RatingsFeedback-Icon.png"),
							VerticalOptions = LayoutOptions.FillAndExpand,
							HorizontalOptions = LayoutOptions.FillAndExpand,
						},
						//Creates the Label, and Adds it's Font Settings (Large Sized and Bold)
						new Label {
							HorizontalOptions = LayoutOptions.CenterAndExpand,
							Text = "Ratings/ \n Feedback",
							TextColor = Color.Black,
							Font = Font.SystemFontOfSize (NamedSize.Large)
								.WithAttributes (FontAttributes.Bold),
						}
					},
					//Ratings/Feedback Column Starts at 1 and Ends at 2
					//Ratings/Feedback Row Starts at 2 and Ends at 3
				}, 1, 2, 2, 3);

			BackgroundColor = Color.White;

			// Accomodate iPhone status bar.
			this.Padding = new Thickness (10, Device.OnPlatform (20, 0, 0), 10, 5);

			Content = grid;


		}

	}

}

