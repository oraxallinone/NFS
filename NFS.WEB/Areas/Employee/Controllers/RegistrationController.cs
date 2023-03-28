using Microsoft.AspNetCore.Mvc;

namespace NFS.WEB.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class RegistrationController : Controller
    {
        public IActionResult AddNew()
        {
            return View();
        }
    }
}
