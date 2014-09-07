using MobileApp.Services;
using MobileApp.ViewModels;
using Xamarin.Forms;

namespace MobileApp.Views
{
	public class MainView : ContentPage
	{
		public MainView()
		{
			BindingContext = new MainViewModel(new MobileDataService());

			var stack = new StackLayout
			{
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};

			var label = new Label
			{
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
			label.SetBinding(Label.TextProperty, new Binding("MessageText"));
			stack.Children.Add(label);

			var label2 = new Label
			{
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Text = "Label #2"
			};
			stack.Children.Add(label2);

			var button = new Button
			{
				Text="Click me please",
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};
			button.Clicked += button_Clicked;
			stack.Children.Add(button);

			Content = stack;
		}

		void button_Clicked(object sender, System.EventArgs e)
		{
			
		}
	}
}