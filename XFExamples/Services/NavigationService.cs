using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFExamples.Services
{
	public class NavigationService : INavigationService
    {
		public INavigation Navigation { get; set; }

		public Task PushAsync<T>() where T : Page, new() => Navigation?.PushAsync(new T());
		public Task<Page> PopAsync() => Navigation?.PopAsync();
    }
}
