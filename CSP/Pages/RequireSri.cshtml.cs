using System.Collections.Generic;
using CSP.Models;

namespace CSP.Pages
{
    public class RequireSriModel : CspModel
    {
        public RequireSriModel(): base()
        {
            NextUrl = "/ButtonWithOnClick";
            NextName = "On click event";
            Policies = new List<string>()
            {
                "upgrade-insecure-requests",
                "block-all-mixed-content",
                "default-src 'self'",
                "img-src *",
                "script-src 'self' https://ajax.aspnetcdn.com",
                "style-src 'self' https://ajax.aspnetcdn.com",
                "font-src 'self' https://ajax.aspnetcdn.com",
                "require-sri-for script style"
            };
        }
    }
}
