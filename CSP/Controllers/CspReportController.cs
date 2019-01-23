using CSP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSP.Controllers
{
    [Route("[controller]")]
    public class CspReportController : Controller
    {
        private readonly ILogger<CspReportController> _logger;

        public CspReportController(ILogger<CspReportController> logger)
        {
            _logger = logger;
        }

        // GET
        public IActionResult Index()
        {
            return
            View();
        }
        
        [HttpPost("")]
        public IActionResult CspReport([FromBody] CspReportRequest cspReport)
        {
            _logger.LogWarning("CSP-Violation - Violated Directive: {0}, Blocked URI: {1}", cspReport.CspReport.ViolatedDirective, cspReport.CspReport.BlockedUri);
            return new OkResult();
        }
    }
}
