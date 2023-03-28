using Microsoft.AspNetCore.Mvc;

namespace NFS.WEB.Areas.HTML.Controllers
{
    [Area("html")]
    public class HtmlWonderWomanController : Controller
    {
        public IActionResult BillDemo()
        {
            return View();
        }
    }
}
