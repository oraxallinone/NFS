using Microsoft.AspNetCore.Mvc;

namespace NFS.WEB.Areas.Blogs.Controllers
{
    [Area("Blogs")]
    public class BangaloreController : Controller
    {
        public IActionResult HSR()
        {
            return View();
        }

        public IActionResult KTM()
        {
            return View();
        }

        public IActionResult SFX()
        {
            return View();
        }

        public IActionResult TMT()
        {
            return View();
        }
    }
}
