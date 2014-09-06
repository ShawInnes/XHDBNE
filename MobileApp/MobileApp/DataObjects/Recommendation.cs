
namespace xhdbneService.DataObjects
{
	public class Recommendation 
	{
		public string Id { get; set; }

		public Journey Journey { get; set; }

		public bool SoundAlarm { get; set; }
	}
}