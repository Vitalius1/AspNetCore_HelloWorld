using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    public class HelloController : Controller
    {
        // [HttpGetAttribute]
        [HttpGet]
        [Route("string")]
        public JsonResult String()
        {
            return Json("hello world");
        }
        
        [HttpGet]
        [Route("number")]
        public JsonResult Number()
        {
            return Json(999);
        }
        
        [HttpGet]
        [Route("object")]
        public JsonResult Obj()
        {
            var AnonObject = new {
                                    FirstName = "Raz",
                                    LastName = "Aquato",
                                    Age = 10
                                };
            return Json(AnonObject);        
        }
    }
}