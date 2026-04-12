using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Utility.WebForms.Core
{
    public class WebFormsPageContext
    {
        public readonly HttpContext HttpContext;
        public readonly HttpRequest Request;
        public readonly HttpResponse Response;

        public string Action = "action"; // TODO: fix


        public WebFormsPageContext(HttpContext httpContext, HttpRequest request, HttpResponse response)
        {
            HttpContext = httpContext;
            Request = request;
            Response = response;
        }
    }
}
