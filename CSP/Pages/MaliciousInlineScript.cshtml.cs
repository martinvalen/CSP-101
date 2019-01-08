using System.Collections.Generic;
using CSP.Models;

namespace CSP.Pages
{
    public class MaliciousInlineScriptModel : CspModel
    {
        public MaliciousInlineScriptModel() : base()
        {
            NextUrl = "/DefaultSrcSelf";
            NextName = "Default-src 'self'";
            Policies = new List<string>()
            {
                "upgrade-insecure-requests",
                "block-all-mixed-content"
            };
        }
    }
}
