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

        public void OnGet()
        {
            Response.Headers.Add("Content-Security-Policy", Policies.Join(";"));
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