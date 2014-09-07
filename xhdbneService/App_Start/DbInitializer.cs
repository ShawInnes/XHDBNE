using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.Mobile.Service;
using XHDBNE.Service.DataObjects;
using XHDBNE.Service.Models;

namespace XHDBNE.Service
{
	public class DbInitializer : ClearDatabaseSchemaIfModelChanges<DataContext>
	{
		protected override void Seed(DataContext context)
		{
			List<Journey> journeys = new List<Journey>
			{
				new Journey { Id = Guid.NewGuid().ToString(), Name = "Fred's Journey" },
				new Journey { Id = Guid.NewGuid().ToString(), Name = "Shaw's Journey" },
				new Journey { Id = Guid.NewGuid().ToString(), Name = "Clearence's Journey" },
			};

			foreach (Journey item in journeys)
			{
				context.Set<Journey>().Add(item);
			}

			base.Seed(context);
		}
	}
}