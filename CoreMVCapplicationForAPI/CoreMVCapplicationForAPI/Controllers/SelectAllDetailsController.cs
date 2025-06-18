using Microsoft.AspNetCore.Mvc;
using CoreMVCapplicationForAPI.Models;


namespace CoreMVCapplicationForAPI.Controllers
{
    public class SelectAllDetailsController : Controller
    {
        public IActionResult AllProfile_page()
        {
            List<Employee> employees = null;

            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri("http://localhost:5171/Test/");    //Api Connect
                client.BaseAddress = new Uri("http://localhost:5240/TestApi/");

                var responseTask = client.GetAsync("GetAlltab");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<Employee>>();
                    readTask.Wait();

                    employees = readTask.Result;
                }
            }

            return View(employees);

        }

//-------------------------------------------Get with ID---------------------------------

        public ActionResult Detailstab(int? id)
        {
            Employee emp = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5171/Test/");
                var responseTask = client.GetAsync($"getWithId/{id}");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Employee>();
                    readTask.Wait();

                    emp = readTask.Result;
                }
                else
                {
                    emp = new Employee(); // fallback if API fails
                }
            }

            return View(emp);
        }

//-------------------------------------Delete ------------------------------
     
        public ActionResult DeleteDB(int id)
        {
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri("http://localhost:5171/Test/");//Api Connect
                client.BaseAddress = new Uri("http://localhost:5240/TestApi/");
                var deleteTask = client.DeleteAsync($"DeleteTab/{id}");
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("AllProfile_page");
                }
            }
            return RedirectToAction("AllProfile_page");
        }

        //--------------------------- Edit ---------------------------------------------

        public IActionResult EditGet(int? id)
        {
            Employee emp = null;

            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri("http://localhost:5171/Test/");  // Api connect
                client.BaseAddress = new Uri("http://localhost:5240/TestApi/");
                var responseTask = client.GetAsync($"UpdateTab/{id}");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Employee>();
                    readTask.Wait();

                    emp = readTask.Result;
                }
                else
                {
                    emp = new Employee(); // fallback if API fails
                }
            }

            return View(emp);
        }
        [HttpPost]
        public ActionResult EditPost(Employee empobj)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    //client.BaseAddress = new Uri("http://localhost:5171/Test/");
                    client.BaseAddress = new Uri("http://localhost:5240/TestApi/");
                    var postTask = client.PutAsJsonAsync<Employee>($"UpdateTab/{empobj.Id}", empobj);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("AllProfile_page");
                    }
                }
            }

            return View(empobj);
        }





    }
}
