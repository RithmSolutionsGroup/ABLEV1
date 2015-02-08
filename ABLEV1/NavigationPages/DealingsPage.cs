using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;
using Xamarin.Forms;

namespace ABLEV1
{
	public partial class DealingsPage : ContentPage
	{
		private static StackLayout Stack;

		async private void OnLayoutClicked (Page page)
		{
			await Navigation.PushAsync (page);
		}

		protected override void OnSizeAllocated (double width, double height)
		{
			base.OnSizeAllocated (width, height);

			//Debug.WriteLine (width.ToString());
			//Debug.WriteLine (height.ToString());

			if (width < height) {
				Stack.Orientation = StackOrientation.Vertical;
			}

			if (height < width) {
				Stack.Orientation = StackOrientation.Vertical;
			}
		}

		public DealingsPage ()
		{

			Stack = new StackLayout ();
			Stack.Orientation = StackOrientation.Vertical;

			//Grid Definitions
			Grid grid = new Grid {
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
								//ABLE Logo Image
								new Image {
									Source = ImageSource.FromResource ("ABLEV1.Images.Logos.ABLE-LOGO-4.png"),
								},
							}
						}
					},
					//Logo Column Starts at 0 and Ends at 2
					//Logo Row Starts at 0 and Ends at 1
				}, 0, 2, 0, 1);

			grid.Children.Add (
				new StackLayout {
					Orientation = StackOrientation.Vertical,
					BackgroundColor = Color.FromHex ("#8095AE"),
					Children = {
						new Label {
							VerticalOptions = LayoutOptions.CenterAndExpand,
							HorizontalOptions = LayoutOptions.CenterAndExpand,
							Text = "Select a behavioral style: ",
							TextColor = Color.White,
						}
					},
				}, 0, 2, 1, 2);

			grid.Children.Add (
				new ScrollView {
					Content = new StackLayout {
						Orientation = StackOrientation.Vertical,
						BackgroundColor = Color.White,
						Padding = new Thickness (20, 25, 20, 0),
						Spacing = 10,
						Children = {
							new Button {
								BackgroundColor = Color.FromHex ("#CAD7EE"),
								Text = "Analytical",
								TextColor = Color.Black,
								BorderRadius = 15,
								HeightRequest = 40,
								Command = new Command (() => OnLayoutClicked(new AnalyticalPage())),
							},
							new Button {
								BackgroundColor = Color.FromHex ("#CAD7EE"),
								Text = "Driver",
								TextColor = Color.Black,
								BorderRadius = 15,
								HeightRequest = 40,
								Command = new Command (() => OnLayoutClicked(new DriverPage())),
							},
							new Button {
								BackgroundColor = Color.FromHex ("#CAD7EE"),
								Text = "Amiable",
								TextColor = Color.Black,
								BorderRadius = 15,
								HeightRequest = 40,
								Command = new Command (() => OnLayoutClicked(new AmiablePage())),
							},
							new Button {
								BackgroundColor = Color.FromHex ("#CAD7EE"),
								Text = "Expressive",
								TextColor = Color.Black,
								BorderRadius = 15,
								HeightRequest = 40,
								Command = new Command (() => OnLayoutClicked(new ExpressivePage())),
							}

						},
					}
				}, 0, 2, 2, 4);


			BackgroundColor = Color.White;

			Stack.Children.Add (grid);
			Content = Stack;

		}
	}
}

