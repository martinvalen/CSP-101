using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using CSP.Models;

namespace CSP.Pages
{
    public class RequireSriModel : CspModel
    {
        public RequireSriModel(): base()
        {
            Policies = new List<string>()
            {
                "upgrade-insecure-requests",
                "default-src 'self'",
                "img-src *",
                "script-src 'self' https://ajax.aspnetcdn.com",
                "require-sri-for script style"
            };
        }
    }
}
