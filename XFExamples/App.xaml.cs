using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFExamples.Services;
using XFExamples.Services.MessageBroker;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XFExamples
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

			DependencyService.Register<INavigationService, NavigationService>();
			DependencyService.Register<IMessageBrokerService, MessageBrokerService>();

			MainPage = new NavigationPage(new MainPage());
			DependencyService.Get<INavigationService>().Navigation = MainPage.Navigation;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
