using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace loginapp
{
	public class LoginModel : INotifyPropertyChanged
	{
		private string _email;
		public string Email { 
			get { return _email; } 
			set { _email = value;
				HasTextFinished ();
				OnPropertyChanged ();
			} 
		} 

		private string _password;
		public string Password 
		{ 
			get { return _password; }
			set { _password = value;
				HasTextFinished ();
				OnPropertyChanged ();
			} 
		} 

		public LoginModel ()
		{

		}

		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion

		public event EventHandler TextFinished;


		protected void HasTextFinished (string text="")
		{
			if (!String.IsNullOrEmpty(Email) && !String.IsNullOrEmpty(Password)) {
				EventHandler handler = TextFinished;
				if (handler != null) {
					handler (this, EventArgs.Empty); 
				}
			}
		}

		// Event - called TextChanged
		// Emit event

		protected void OnPasswordChanged(string text) {
		}

		protected void OnPropertyChanged([CallerMemberName] string text="")
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null) 
			{
				handler (this, new PropertyChangedEventArgs (text));
			}
		}
	}
}

