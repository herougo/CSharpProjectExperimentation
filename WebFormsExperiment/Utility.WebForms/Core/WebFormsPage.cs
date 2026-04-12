using System;
using Utility.Core;

namespace Utility.WebForms.Core
{
    public class WebFormsPage : System.Web.UI.Page
    {
        public WebFormsPage() : base()
        {
            Logger.LogInfo("WebFormsPage constructor");
        }

        protected void PageLoad(object sender, EventArgs e)
        {
            Logger.LogInfo("WebFormsPage PageLoad");
        }
    }
}
