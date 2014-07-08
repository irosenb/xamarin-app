using System;
using Xamarin.Forms;

namespace loginapp
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new NavigationPage(new Login ());
		}
	}
}

