using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace loginapp
{
	public class InputForm : StackLayout
	{
		public Entry InputEntry { get; set; } 
		public InputForm (string label, bool password=false)
		{
			var inputLabel = new Label
			{
				Text = label + ":"
			};

			InputEntry = new Entry {
				Placeholder = label,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};

			Spacing = 2;
			Orientation = StackOrientation.Horizontal;
			HorizontalOptions = LayoutOptions.FillAndExpand;

			Children.Add (inputLabel);
			Children.Add (InputEntry);

			
		}
	}
}

