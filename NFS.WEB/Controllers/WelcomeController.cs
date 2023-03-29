using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NFS.WEB.Models;

namespace NFS.WEB.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            var sss = SearchCustomers();

            //return View("~/Areas/Blogs/Views/Home/Index.cshtml");
            return View();
        }

        public IActionResult CarEMI()
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


    }
}
