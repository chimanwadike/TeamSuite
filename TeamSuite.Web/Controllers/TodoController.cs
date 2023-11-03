using Microsoft.AspNetCore.Mvc;

namespace TeamSuite.Web.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
