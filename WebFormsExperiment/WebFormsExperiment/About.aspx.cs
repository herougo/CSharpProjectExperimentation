using System;
using Utility.Core;
using Utility.WebForms.Core;

namespace WebFormsExperiment
{
    public partial class About : WebFormsPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Logger.LogInfo("About.aspx.cs Page_Load");
            PageLoad(sender, e);

            try
            {
                // Logger.LogInfo("About.aspx.cs Before Redirect");
                // Response.Redirect("/Contact.aspx");
                // Logger.LogInfo("About.aspx.cs After Redirect");
            }
            catch (Exception ex)
            {
                Logger.LogInfo($"About.aspx.cs exceptioin: {ex.Message}");
                throw;
            }
            
        }
    }
}