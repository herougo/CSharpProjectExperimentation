using System;
using Utility.Core;
using Utility.WebForms.Features.PageLoadResult;
using Utility.WebForms.Features.PageLoadResult.Services;

namespace Utility.WebForms.Core
{
    public class WebFormsPage : System.Web.UI.Page
    {
        private void StartPageLoad(object sender, EventArgs e)
        {

        }

        protected virtual PageLoadResult PageLoadImpl(WebFormsPageContext pageContext)
        {
            return new PageLoadResult();
        }

        private void EndPageLoad(object sender, EventArgs e, WebFormsPageContext context, PageLoadResult result)
        {
            var pageLoadResultProcessor = new PageLoadResultProcessor();
            pageLoadResultProcessor.Process(context, result);
        }

        protected void PageLoad(object sender, EventArgs e)
        {
            StartPageLoad(sender, e);
            WebFormsPageContext pageContext = WebFormsUtils.ExtractFullContext(this, sender, e);
            PageLoadResult result = PageLoadImpl(pageContext);
            EndPageLoad(sender, e, pageContext, result);
        }
    }
}
