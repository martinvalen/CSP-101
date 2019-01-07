using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using CSP.Models;

namespace CSP.Pages
{
    public class InlineScriptHashModel : CspModel
    {

        public InlineScriptHashModel(): base()
        {
            Policies = new List<string>()
            {
                "upgrade-insecure-requests",
                "default-src 'self'",
                "img-src *",
                "script-src 'self' 'sha256-cV528yMJHA/kQgf9P6Fk2CaXr+LYxNZWtGju6quh8Pw='"
            };
        }
    }
}
