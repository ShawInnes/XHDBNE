using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;
using xhdbneService.DataObjects;

namespace MobileApp
{
	public class App
	{
		const string applicationURL = @"https://xhdbne.azure-mobile.net/";
		const string applicationKey = @"eHKXTbVylhQZpbaWteIBmUvMSYugzG11";

		static MobileServiceClient client;

		public App()
		{
			client = new MobileServiceClient(applicationURL, applicationKey);			
		}

		public static Page GetMainPage()
		{

			// Create an MSTable instance to allow us to work with the TodoItem table
			//todoTable = client.GetTable<ToDoItem>();
			var journeys = client.GetTable<Journey>();

			return new ContentPage
			{
				Content = new Label
				{
					Text = "Hello, Forms !",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
			};
		}
	}
}
