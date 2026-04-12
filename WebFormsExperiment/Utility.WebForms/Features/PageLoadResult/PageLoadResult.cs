using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.WebForms.Features.PageLoadResult
{
    public class PageLoadResult
    {
        private string _redirectUrl = "";
        public string RedirectUrl { get { return _redirectUrl; } }

        private bool _shouldRedirect = false;
        public bool ShouldRedirect { get { return _shouldRedirect; } }


        public PageLoadResult() { }

        public void AddRedirect(string redirectUrl)
        {
            _redirectUrl = redirectUrl;
            _shouldRedirect = true;
        }

        public void RemoveRedirect()
        {
            _redirectUrl = "";
            _shouldRedirect = false;
        }
    }
}
