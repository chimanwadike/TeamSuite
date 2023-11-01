using Microsoft.AspNetCore.Mvc;

namespace TeamSuite.Web.Areas.Management.Controllers
{
    public class MembersController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
