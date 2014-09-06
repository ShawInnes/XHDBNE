using Microsoft.WindowsAzure.Mobile.Service;

namespace xhdbneService.DataObjects
{
	public class Recommendation : EntityData, IRecommendation
	{
		public IJourney Journey { get; set; }

		public bool SoundAlarm { get; set; }
	}
}