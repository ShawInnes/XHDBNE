namespace xhdbneService.DataObjects
{
	public interface IRecommendation
	{
		IJourney Journey { get; set; }

		bool SoundAlarm { get; set; }
	}
}