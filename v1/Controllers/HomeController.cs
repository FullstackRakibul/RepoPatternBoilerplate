using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace v1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("Test")]
        public ActionResult Index()
        {
            return View();
        }

        
    }
}
