using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;
using xhdbneService.DataObjects;
using System.Threading.Tasks;

namespace MobileApp
{
	public class App
	{
		const string applicationURL = @"https://xhdbne.azure-mobile.net/";
		const string applicationKey = @"eHKXTbVylhQZpbaWteIBmUvMSYugzG11";

		static MobileServiceClient client;

		public static async Task GetData()
		{
			var journeyTable = client.GetTable<Journey>();

			var result = await journeyTable.Where(p => p.Name != "").ToListAsync();

			int count = result.Count;
		}

		public static Page GetMainPage()
		{
			client = new MobileServiceClient(applicationURL, applicationKey);			

			// Create an MSTable instance to allow us to work with the TodoItem table
			//todoTable = client.GetTable<ToDoItem>();

			Task task = GetData();
			task.Wait(5000);

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
