using System.Collections.Generic;
using System.Threading.Tasks;
using xhdbneService.DataObjects;

namespace MobileApp.Interfaces
{
	public interface IMobileDataService
	{
		Task<List<Journey>> GetData();
	}
}