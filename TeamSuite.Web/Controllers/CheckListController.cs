using Microsoft.AspNetCore.Mvc;

namespace TeamSuite.Web.Controllers
{
    public class CheckListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
