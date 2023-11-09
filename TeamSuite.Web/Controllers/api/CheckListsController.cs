using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamSuite.Contracts;

namespace TeamSuite.Web.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CheckListsController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public CheckListsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult Get(string checklistFormId)
        {
            var checklist = _serviceManager
                .CheckListReportService
                .GetTodayCheckList(Guid.Parse(checklistFormId));
            
            return Ok(checklist);
        }

        [HttpPost]
        public IActionResult GenerateForm([FromBody] string checklistFormId)
        {
            _serviceManager
                .CheckListReportService
                .GenerateTodayCheckList(Guid.Parse(checklistFormId));

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStatus(string id, [FromBody] string status)
        {
            _serviceManager.CheckListReportService.UpdateStatus(Guid.Parse(id), Guid.Parse(status));
            return Ok(status);
        }
    }
}
