using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Utility.WebForms.Core
{
    internal static class WebFormsUtils
    {
        public static WebFormsPageContext ExtractFullContext(WebFormsPage page, object sender, EventArgs e)
        {
            return new WebFormsPageContext(HttpContext.Current, page.Request, page.Response);
        }
    }
}
