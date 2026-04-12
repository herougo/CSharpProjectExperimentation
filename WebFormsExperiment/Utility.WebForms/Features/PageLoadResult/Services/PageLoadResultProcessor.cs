using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.WebForms.Core;

namespace Utility.WebForms.Features.PageLoadResult.Services
{
    public class PageLoadResultProcessor
    {
        public void Process(WebFormsPageContext context, PageLoadResult result)
        {
            if (result.ShouldRedirect)
            {
                context.Response.Redirect(result.RedirectUrl);
            }
        }
    }
}
