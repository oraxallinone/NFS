using Microsoft.AspNetCore.Mvc;

namespace NFS.WEB.Areas.JQuery.Controllers
{
    [Area("jquery")]
    public class JqueryVissionController : Controller
    {
        public IActionResult JqueryWithCookies()
        {
            return View();
        }

        public IActionResult CalenderFormat()
        {
            return View();
        }

        public IActionResult PressEnterKey()
        {
            return View();
        }
    }
}
