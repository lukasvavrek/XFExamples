using System.Windows.Input;
using Xamarin.Forms;
using XFExamples.Services;
using XFExamples.Services.MessageBroker;

namespace XFExamples.ViewModels
{
    public class DetailPageViewModel
    {
		public string LabelText { get; }
		public string NavigateBackText => "Go back to Main page";

		public ICommand NavigateBackCommand => new Command(NavigateBack);

		private INavigationService _navigationService;

		public DetailPageViewModel()
			: this(
				DependencyService.Get<INavigationService>(),
				DependencyService.Get<IMessageBrokerService>()
			)
		{}

        public DetailPageViewModel(
			INavigationService navigationService,
			IMessageBrokerService messageBrokerService
		)
        {
			_navigationService = navigationService;

			LabelText = messageBrokerService
				.ReceiveMessage<MasterDetailNavigationMessage>()
				?.Message ?? "Message receive failed";
        }

		private void NavigateBack()
		{
			_navigationService.PopAsync();
		}
    }
}
