using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFExamples.Services
{
	public interface INavigationService
    {
		INavigation Navigation { get; set; }

		Task PushAsync<T>() where T: Page, new();
		Task<Page> PopAsync();
    }
}
