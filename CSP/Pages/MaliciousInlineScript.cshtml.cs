using System.Collections.Generic;
using CSP.Models;

namespace CSP.Pages
{
    public class MaliciousInlineScriptModel : CspModel
    {
        public MaliciousInlineScriptModel() : base()
        {
            Policies = new List<string>()
            {
                "upgrade-insecure-requests"
            };
        }
    }
}
