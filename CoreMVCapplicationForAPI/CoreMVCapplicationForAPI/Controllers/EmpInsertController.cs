using Microsoft.AspNetCore.Mvc;
using CoreMVCapplicationForAPI.Models;
using System.Net.Http;

namespace CoreMVCapplicationForAPI.Controllers
{
    public class EmpInsertController : Controller
    {
        //EmployeeDB dbobj = new EmployeeDB();

        // Page Load
        public ActionResult Index_Pageload()
        {
            return View();
        }

        // On Button Click - Insert Data
        [HttpPost]
        public ActionResult Index_click(Employee obcls)
        {
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri("http://localhost:5171/Test/"); //API Adding To mvc
                client.BaseAddress = new Uri("http://localhost:5240/TestApi/");


                // HTTP POST
                var postTask = client.PostAsJsonAsync<Employee>("posttab", obcls);
                postTask.Wait();

                var result = postTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    // Redirect after successful insert
                    return RedirectToAction("AllProfile_page", "SelectAllDetails");
                }
            }
            return RedirectToAction("AllProfile_page", "SelectAllDetails");

        }
    }
}
