using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TeamSuite.Web.Controllers
{
    [Authorize]
    public class CheckListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
