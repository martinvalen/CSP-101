﻿using System.Collections.Generic;
using CSP.Models;

namespace CSP.Pages
{
    public class DefaultSrcSelfModel : CspModel
    {
        public DefaultSrcSelfModel(): base()
        {
            Policies = new List<string>()
            {
                "upgrade-insecure-requests",
                "default-src 'self'"
            };
        }
    }
}
