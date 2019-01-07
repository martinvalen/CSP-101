using System.Collections.Generic;
using CSP.Models;

namespace CSP.Pages
{
    public class ButtonWithOnClickModel : CspModel
    {
        public ButtonWithOnClickModel(): base()
        {
            Policies = new List<string>()
            {
                "upgrade-insecure-requests",
                "default-src 'self'",
                "img-src *",
                "script-src 'self' https://ajax.aspnetcdn.com",
                "require-sri-for script style",
            };
        }
    }
}
