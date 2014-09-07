using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace XHDBNE.Service.DataObjects
{
	public class Journey : EntityData, IJourney
	{
		public string Name { get; set; }

		public int UsualTravelTime { get; set; }
	}
}