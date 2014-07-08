using System;
using Xamarin.Forms;

namespace loginapp
{
	public class Login : ContentPage
	{
		public Login ()
		{
		
			var model = new LoginModel ();

			this.BindingContext = model;

			var Email = new Entry {
				Placeholder = "Email",
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			
			var Password = new Entry {
				Placeholder = "Password",
				HorizontalOptions = LayoutOptions.FillAndExpand
			};

			Email.SetBinding(Entry.TextProperty, "Email");
			Password.SetBinding(Entry.TextProperty, "Password");

			var label = new Label {
				Text = "No Change"
			};

			Button Enter = new Button { 
				Text = "Enter",
				HorizontalOptions = LayoutOptions.FillAndExpand,
				IsEnabled = false
			}; 

			Content = new StackLayout {
				VerticalOptions = LayoutOptions.CenterAndExpand,
//				BackgroundColor = Color.Aqua,
				Children = { Email, Password, Enter, label }
			};

			model.TextFinished += (sender, eventArgs) => {
				Enter.IsEnabled = true;
			};

			model.PropertyChanged += (sender, e) => {
				label.Text = e.PropertyName + " changed";
			};

			Enter.Clicked += async (object sender, EventArgs e) => {
				if (Email.Text == "hi@xamarin.com" && Password.Text == "hi") {
					await Navigation.PushAsync (new NavigationPage(new ListPage ()));
				}
			};
		}
	}
}

