using Microsoft.AspNetCore.Mvc;

namespace NFS.WEB.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            //return View("~/Areas/Blogs/Views/Home/Index.cshtml");
            return View();
        }

        public IActionResult CarEMI()
        {
            return View();
        }


    }
}
