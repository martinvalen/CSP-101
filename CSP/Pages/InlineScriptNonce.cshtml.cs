﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using CSP.Models;

namespace CSP.Pages
{
    public class InlineScriptNonceModel : CspModel
    {
        public string ScriptNonce { get; set; }

        public InlineScriptNonceModel(): base()
        {
            ScriptNonce = GetUniqueKey(100);
            Policies = new List<string>()
            {
                "upgrade-insecure-requests",
                "block-all-mixed-content",
                "default-src 'self'",
                "script-src 'self' https://ajax.aspnetcdn.com 'nonce-" + ScriptNonce + "'",
                "style-src 'self' https://ajax.aspnetcdn.com"
            };
        }

        private static string GetUniqueKey(int size)
        {
            var chars =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            var data = new byte[size];
            using (var crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            var result = new StringBuilder(size);
            foreach (var b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
    }
}
