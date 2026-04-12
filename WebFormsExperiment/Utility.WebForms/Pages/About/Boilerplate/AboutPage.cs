using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.WebForms.Core;
using Utility.WebForms.Features.PageLoadResult;

namespace Utility.WebForms.Pages.About.Boilerplate
{
    public class AboutPage : WebFormsPage
    {
        public AboutPageState State = new AboutPageState();
        public PageLoadResult PageLoadResult = null;

        protected override PageLoadResult PageLoadImpl(WebFormsPageContext pageContext)
        {
            var pageState = State;

            var pageLoaderFactory = new AboutPageLoaderFactory();
            var pageLoader = pageLoaderFactory.Create(pageContext.Action);
            return pageLoader.Load(pageContext, pageState);
        }
    }
}
