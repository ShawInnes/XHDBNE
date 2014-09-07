namespace XHDBNE.Service.DataObjects
{
	public interface IRecommendation
	{
		IJourney Journey { get; set; }

		bool SoundAlarm { get; set; }
	}
}