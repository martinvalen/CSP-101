using System.Collections.Generic;
using CSP.Models;

namespace CSP.Pages
{
    public class ImgSrcModel : CspModel
    {
        public ImgSrcModel(): base()
        {
            Policies = new List<string>()
            {
                "upgrade-insecure-requests",
                "block-all-mixed-content",
                "default-src 'self'",
                "img-src *"
            };
        }
    }
}
