using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NFS.WEB.Models;

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

        public IActionResult ListOfEmployee()
        {
            return View(SearchCustomers());
        }
        [HttpGet]
        public IActionResult DetailsOfEmployee(Employee emp)
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditOfEmployee(Employee emp)
        {
            return View();
        }
        [HttpPut]
        public IActionResult UpdateOfEmployee(Employee emp)
        {
            return View();
        }

        [HttpDelete]
        public IActionResult DeleteOfEmployee(Employee emp)
        {
            return View();
        }


        private List<Employee>? SearchCustomers()
        {
            List<Employee>? emps = new List<Employee>();
            string apiUrl = "https://localhost:7152/api/orax";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(apiUrl + string.Format("/GetEmployees")).Result;
            if (response.IsSuccessStatusCode)
            {
                emps = JsonConvert.DeserializeObject<List<Employee>>(response.Content.ReadAsStringAsync().Result);
            }
            return emps;
        }

        public int Addition(int a,int b)
        {
             
            return a +b ;
        }





    }
}
