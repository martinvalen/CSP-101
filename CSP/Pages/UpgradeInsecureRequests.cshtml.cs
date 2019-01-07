using System.Collections.Generic;
using CSP.Models;

namespace CSP.Pages
{
    public class UpgradeInsecureRequestsModel : CspModel
    {
        public UpgradeInsecureRequestsModel() : base()
        {
            Policies = new List<string>()
            {
                "upgrade-insecure-requests",
                "block-all-mixed-content"
            };
        }
    }
}
