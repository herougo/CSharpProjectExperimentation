using Utility.WebForms.Pages.About.PageLoaders;
using Utility.WebForms.Pages.About.PageLoaders.Page;

namespace Utility.WebForms.Pages.About.Boilerplate
{
    public class AboutPageLoaderFactory
    {
        public AboutMainPageLoader Create(string action)
        {
            return new AboutMainPageLoader();
        }
    }
}
