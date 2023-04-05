using Microsoft.AspNetCore.Mvc;

namespace NFS.WEB.Areas.DevExpress.Controllers
{
    [Area("DevExpress")]
    public class DevExpressAController : Controller
    {
        public IActionResult DataGrid()
        {
            return View();
        }

        public IActionResult DevExtrimButton()
        {
            return View();
        }
        public IActionResult DropDown()
        {
            return View();
        }
        public IActionResult Accordion()
        {
            return View();
        }

        public IActionResult Autocomplete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchEmployeName( string userId)
        {
            return Json(userId);
        }
    }
}
