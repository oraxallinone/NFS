using Microsoft.AspNetCore.Mvc;

namespace NFS.WEB.Areas.AppDemo.Controllers
{
    [Area("AppDemo")]
    public class NarniaController : Controller
    {
        public IActionResult LoginDemo()
        {
            return View();
        }
    }
}
