using System;
using System.Windows.Input;
using Xamarin.Forms;
using XFExamples.Services;
using XFExamples.Services.MessageBroker;
using XFExamples.Views;

namespace XFExamples.ViewModels
{
	public class MainPageViewModel
	{
		public string ButtonText => "Navigate to detail";

		public ICommand NavigateToDetailPageCommand => new Command(NavigateToDetailPage);

		private INavigationService _navigationService;
		private IMessageBrokerService _messageBrokerService;

		public MainPageViewModel()
			: this(
				DependencyService.Get<INavigationService>(),
				DependencyService.Get<IMessageBrokerService>()
			)
		{ }

		public MainPageViewModel(
			INavigationService navigationService,
			IMessageBrokerService messageBrokerService
		)
		{
			_navigationService = navigationService;
			_messageBrokerService = messageBrokerService;
		}

		private void NavigateToDetailPage() 
		{
			_messageBrokerService.SendMessage(new MasterDetailNavigationMessage(DateTime.Now.ToString("g")));
			_navigationService.PushAsync<DetailPage>();
		}
	}
}
