using System.Collections.Generic;
using CSP.Models;

namespace CSP.Pages
{
    public class ButtonWithEventListenerModel : CspModel
    {
        public ButtonWithEventListenerModel(): base()
        {
            Policies = new List<string>()
            {
                "upgrade-insecure-requests",
                "default-src 'self'",
                "img-src *",
                "script-src 'self'",
                "form-action 'self' https://placeyouwanttosendformsto.com"
            };
        }
    }
}
