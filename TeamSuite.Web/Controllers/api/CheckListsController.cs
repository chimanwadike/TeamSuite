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
        public IActionResult Get(string checklistFormId)
        {
            var checklist = _serviceManager
                .CheckListReportService
                .GetTodayCheckList(Guid.Parse(checklistFormId));

            //todo:: switch to automapper or mapster
            var mapped_checklist = checklist.Select(_ => new { Id = _.Id, Location = _.CheckList.Location.Name, Action = _.CheckList.CheckListItem.Name, Status = _.Status, Completed = _.Completed, Order = _.CheckList.Order });
            
            return Ok(mapped_checklist);
        }

        [HttpPost]
        public IActionResult GenerateForm([FromBody] string checklistFormId)
        {
            _serviceManager
                .CheckListReportService
                .GenerateTodayCheckList(Guid.Parse(checklistFormId));

            return Ok();
        }
    }
}
