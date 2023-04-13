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

        public IActionResult Loby()
        {
            return View();
        }
        public IActionResult InputDemo()
        {
            return View();
        }
        public IActionResult DefaultPage()
        {
            return View();
        }
    }
}
