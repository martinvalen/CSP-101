using System.Collections.Generic;
using CSP.Models;

namespace CSP.Pages
{
    public class ScriptSrcOthersModel : CspModel
    {
        public ScriptSrcOthersModel(): base()
        {
            NextUrl = "/ImgSrc";
            NextName = "Img-src";
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
