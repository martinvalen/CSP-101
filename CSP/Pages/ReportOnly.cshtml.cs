using System.Collections.Generic;
using CSP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSP.Pages
{
    public class ReportOnlyModel : CspModel
    {
        public ReportOnlyModel() : base()
        {
            NextUrl = "/ReportWizard";
            NextName = "Report Wizard";
            Policy = "Content-Security-Policy-Report-Only";
            Policies = new List<string>()
            {
                "upgrade-insecure-requests",
                "block-all-mixed-content",
                "default-src 'self'",
                "img-src *",
                "script-src 'self' https://ajax.aspnetcdn.com",
                "font-src 'self' https://ajax.aspnetcdn.com",
                "style-src 'self' https://ajax.aspnetcdn.com",
                "require-sri-for script style",
                "form-action 'self'",
                "report-uri https://cspmartinvalen.report-uri.com/r/d/csp/reportonly"
            };
        }
    }
}
