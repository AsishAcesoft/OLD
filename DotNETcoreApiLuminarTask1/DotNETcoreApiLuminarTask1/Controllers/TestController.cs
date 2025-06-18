//using Microsoft.AspNetCore.Mvc;
//using DotNETcoreApiLuminarTask1.Model;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace DotNETcoreApiLuminarTask1.Controllers
//{
//    //[Route("api/[controller]")]
//    [Route("Test")]
//    [ApiController]
//    public class TestController : ControllerBase
//    {

//        EmployeeDB dbobj = new EmployeeDB();   /// Extra Added
//        // GET: api/<TestController>
//        [HttpGet]
//        public IEnumerable<string> Get()
//        {
//            return new string[] { "value1", "value2" };
//        }

//        // GET api/<TestController>/5
//        [HttpGet("{id}")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST api/<TestController>
//        [HttpPost]
//        [Route("Posttab")]
//        public void Post(Employee clsobj)
//        {
//            dbobj.InsertDB(clsobj);

//        }

//        // PUT api/<TestController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE api/<TestController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}



//------------------------------------test------------------------------------------------

//using Microsoft.AspNetCore.Mvc;
//using DotNETcoreApiLuminarTask1.Model;

//namespace DotNETcoreApiLuminarTask1.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class TestController : ControllerBase
//    {
//        EmployeeDB dbobj = new EmployeeDB();

//        [HttpGet("GetAll")]
//        public ActionResult<IEnumerable<Employee>> GetAll()
//        {
//            return Ok(dbobj.SelectDB());
//        }

//        [HttpPost("Insert")]
//        public IActionResult Post([FromBody] Employee clsobj)
//        {
//            var result = dbobj.InsertDB(clsobj);
//            return Ok(result);
//        }

//        [HttpPut("Update")]
//        public IActionResult Update([FromBody] Employee emp)
//        {
//            var result = dbobj.UpdateDB(emp);
//            return Ok(result);
//        }

//        [HttpDelete("Delete/{id}")]
//        public IActionResult Delete(int id)
//        {
//            var result = dbobj.DeleteDB(id);
//            return Ok(result);
//        }
//    }
//}


//--------------------------------------------------------------------------------------------------------



using Microsoft.AspNetCore.Mvc;
using DotNETcoreApiLuminarTask1.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNETcoreApiLuminarTask1.Controllers
{
    //[Route("api/[controller]")]
    [Route("Test")]
    [ApiController]
    public class TestController : ControllerBase
    {

        EmployeeDB dbobj = new EmployeeDB();   /// Extra Added
        // GET: api/<TestController>
        [HttpGet]
        [Route("GetAlltab")]
        public List<Employee> Get()
        {
            return dbobj.SelectDB();
        }

        // GET api/<TestController>/5
        [HttpGet]
        [Route("getWithId/{id}")]
        public Employee Get(int id)
        {
            var emp = dbobj.SelectDetailsWithId(id); // Method 1
            //var getEmployee = dbobj.SelectDB().Where(x => x.Id == id).FirstOrDefault();
            //return getEmployee;   // Method 2
            return emp;



        }

        // POST api/<TestController>
        [HttpPost]
        [Route("Posttab")]
        public void Post(Employee clsobj)
        {
            dbobj.InsertDB(clsobj);

        }

        // PUT api/<TestController>/5
        [HttpPut]
        [Route("Updatetab/{id}")]
        public void Put(int id, Employee obj)
        {
            obj.Id = id;       // Set the ID from the route
            dbobj.UpdateDB(obj); 
            
        }

        // DELETE api/<TestController>/5
        [HttpDelete]
        [Route("deletetab/{id}")]
        public void Delete(int id)
        {
            dbobj.DeleteDB(id);
        }
    }
}

