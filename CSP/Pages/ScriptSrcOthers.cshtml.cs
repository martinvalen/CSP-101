using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using CSP.Models;

namespace CSP.Pages
{
    public class ScriptSrcOthersModel : CspModel
    {
        public ScriptSrcOthersModel(): base()
        {
            Policies = new List<string>()
            {
                "upgrade-insecure-requests",
                "block-all-mixed-content",
                "default-src 'self'",
                "script-src 'self' https://ajax.aspnetcdn.com",
                "font-src 'self' https://ajax.aspnetcdn.com",
                "style-src 'self' https://ajax.aspnetcdn.com"
            };
        }
    }
}
