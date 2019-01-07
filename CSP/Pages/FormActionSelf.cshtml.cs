using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using CSP.Models;

namespace CSP.Pages
{
    public class FormActionModel : CspModel
    {
        public FormActionModel(): base()
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
