using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using MobileApp.Interfaces;
using xhdbneService.DataObjects;

namespace MobileApp.Services
{
	public class MobileDataService : IMobileDataService
	{
		private const string applicationURL = @"https://xhdbne.azure-mobile.net/";
		private const string applicationKey = @"eHKXTbVylhQZpbaWteIBmUvMSYugzG11";

		public MobileDataService()
		{
		}

		public async Task<List<Journey>> GetData()
		{
			return new List<Journey>();
		}
	}
}