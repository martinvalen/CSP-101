using System.Collections.Generic;
using CSP.Models;

namespace CSP.Pages
{
    public class InlineScriptHashModel : CspModel
    {

        public InlineScriptHashModel(): base()
        {
            NextUrl = "/NoMoreInline";
            NextName = "Remove inline script";
            Policies = new List<string>()
            {
                "upgrade-insecure-requests",
                "block-all-mixed-content",
                "default-src 'self'",
                "img-src *",
                "script-src 'self' https://ajax.aspnetcdn.com 'sha256-cV528yMJHA/kQgf9P6Fk2CaXr+LYxNZWtGju6quh8Pw='",
                "font-src 'self' https://ajax.aspnetcdn.com",
                "style-src 'self' https://ajax.aspnetcdn.com",
            };
        }
    }
}
