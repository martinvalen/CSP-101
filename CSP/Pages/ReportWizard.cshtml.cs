using System.Collections.Generic;
using CSP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSP.Pages
{
    public class ReportWizardModel : CspModel
    {
        public ReportWizardModel() : base()
        {
            Policy = "Content-Security-Policy-Report-Only";
            Policies = new List<string>()
            {
                "default-src 'none'",
                "form-action 'none'",
                "frame-ancestors 'none'",
                "report-uri https://cspmartinvalen.report-uri.com/r/d/csp/wizard"
            };
        }
    }
}
