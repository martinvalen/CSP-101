using System.Collections.Generic;
using CSP.Models;

namespace CSP.Pages
{
    public class ImgSrcModel : CspModel
    {
        public ImgSrcModel(): base()
        {
            NextUrl = "/InlineScriptNonce";
            NextName = "Script nonce";
            Policies = new List<string>()
            {
                "upgrade-insecure-requests",
                "block-all-mixed-content",
                "default-src 'self'",
                "script-src 'self' https://ajax.aspnetcdn.com",
                "font-src 'self' https://ajax.aspnetcdn.com",
                "style-src 'self' https://ajax.aspnetcdn.com",
                "img-src *"
            };
        }
    }
}
