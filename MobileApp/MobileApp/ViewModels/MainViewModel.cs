using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MobileApp.Annotations;
using MobileApp.Interfaces;
using MobileApp.Services;
using Serilog;

namespace MobileApp.ViewModels
{
	public class MainViewModel : INotifyPropertyChanged
	{
		private readonly IMobileDataService service;
		private string messageText;

		public MainViewModel(IMobileDataService service)
		{
			this.service = service;

			MessageText = "Hello World!";

			LoadData();
		}

		public async Task LoadData()
		{
			var result = await service.GetData();
			foreach (var journey in result)
			{
				Log.Information("Journey: {@journey}", journey);
			}
		}

		public string MessageText
		{
			get { return messageText; }
			set
			{
				if (value == messageText) return;
				messageText = value;
				OnPropertyChanged();
			}
		}

		#region INPC
		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion
	}
}