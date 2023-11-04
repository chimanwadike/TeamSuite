using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamSuite.Contracts;

namespace TeamSuite.Web.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckListsController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public CheckListsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var checklist = _serviceManager.CheckListService.GetCheckList();
            return Ok(checklist);
        }
    }
}
