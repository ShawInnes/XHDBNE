using System.Net.Http.Headers;
using MobileApp.Views;
using Serilog;
using Xamarin.Forms;

namespace MobileApp
{
	public class App
	{
		public static Page GetMainPage()
		{
			return new MainView();
		}
	}
}