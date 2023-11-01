using Microsoft.AspNetCore.Mvc;

namespace TeamSuite.Web.Areas.Management.Controllers
{    
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
