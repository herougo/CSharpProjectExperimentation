using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.WebForms.Core;
using Utility.WebForms.Features.PageLoadResult;

namespace Utility.WebForms.Pages.About.PageLoaders.Page
{
    public class AboutMainPageLoader
    {
        public PageLoadResult Load(WebFormsPageContext context, AboutPageState state)
        {
            var result = new PageLoadResult();

            result.AddRedirect("~/Contact.aspx");

            return result;
        }
    }
}
