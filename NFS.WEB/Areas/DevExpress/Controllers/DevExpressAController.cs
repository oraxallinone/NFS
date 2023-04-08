using Microsoft.AspNetCore.Mvc;
using NFS.WEB.Models;
using System.Drawing;

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

        public IActionResult TextBox()
        {
            return View();
        }

        public IActionResult Button()
        {
            return View();
        }

        public IActionResult GridView()
        {
            return View();
        }
        public IActionResult DateBox()
        {
            return View();
        }












        [HttpPost]
        public IActionResult SearchEmployeName( string userId)
        {
            return Json(userId);
        }

        [HttpGet]
        public IActionResult GetDepartments()
        {
            List<Employee> employees3 = new List<Employee>();
            Employee e1= new Employee();
            e1.Id= 1;
            e1.EmpName = "sa1";
            employees3.Add(e1);

            Employee e2 = new Employee();
            e2.Id = 2;
            e2.EmpName = "sa2";
            employees3.Add(e2);

            Employee e3 = new Employee();
            e3.Id = 3;
            e3.EmpName = "sa3";
            employees3.Add(e3);

            return Json(employees3);
        }

    }
}

