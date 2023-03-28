using Microsoft.AspNetCore.Mvc;

namespace NFS.WEB.Areas.Bootstrap.Controllers
{
    [Area("Bootstrap")]
    public class BootstrapHulkController : Controller
    {
        public IActionResult ModelPopup()
        {
            return View();
        }
        public IActionResult Accordion()
        {
            return View();
        }

        public IActionResult Card()
        {
            return View();
        }
    }
}
