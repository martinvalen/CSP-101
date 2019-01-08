using System.Collections.Generic;
using CSP.Models;

namespace CSP.Pages
{
    public class IndexModel : CspModel
    {
        public IndexModel() : base()
        {
            NextUrl = "/UpgradeInsecureRequests";
            NextName = "Upgrade Insecure Requests";
            Policies = new List<string>()
            {
            };
        }
    }
}
