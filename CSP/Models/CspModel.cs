using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Internal;

namespace CSP.Models
{
    public class CspModel : PageModel
    {
        public IEnumerable<string> Policies { get; set; }
        public string NextUrl { get; set; }
        public string NextName { get; set; }

        public void OnGet()
        {
            Response.Headers.Add("Content-Security-Policy", Policies.Join(";"));
            Response.Headers.Add("Report-To", "{'group':'default','max_age':31536000,'endpoints':[{'url':'https://cspmartinvalen.report-uri.com/a/d/g'}],'include_subdomains':false}");
            Response.Headers.Add("NEL", "{'report_to':'default','max_age':31536000,'include_subdomains':false}");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage();
        }
    }
}