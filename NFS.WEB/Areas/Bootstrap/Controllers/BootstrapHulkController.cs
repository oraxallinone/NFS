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
    }
}
