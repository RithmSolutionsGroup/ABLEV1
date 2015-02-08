using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace ABLEV1
{
	public partial class QCardView : ContentView
	{
		private bool cardFlipped = false;
		Frame frontLayout, backLayout;

		public string frontLabel {
			get;
			set;
		}

		public string backLabel {
			get;
			set;
		}

		public QCardView (){
			Debug.WriteLine (cardFlipped);

			frontLayout = new Frame {
				OutlineColor = Color.Black,
				Padding = new Thickness(0, 0),
				Content = 
					new Button{
						Text = "Hello World",
						TextColor = Color.Black,
						HeightRequest = 100,
						BackgroundColor = Color.FromHex("#F7ECC9"),
						Command = new Command (() => flipCard()),
					},
				
			};

			backLayout = new Frame {
				OutlineColor = Color.Black,
				Padding = new Thickness(0,0),
				Content = 
					new Button{
						Text = backLabel,
						TextColor = Color.Black,
						HeightRequest = 100,
						BackgroundColor = Color.FromHex("#00CC66"),
						Command = new Command (() => flipCard()),
				},
			};

			Content = frontLayout;

		}

		private void flipCard(){
			Debug.WriteLine (cardFlipped);
			cardFlipped = !cardFlipped;
			Debug.WriteLine (cardFlipped);

			if (cardFlipped)
				Content = backLayout;
			else
				Content = frontLayout;
				
		}
			
	}
}

