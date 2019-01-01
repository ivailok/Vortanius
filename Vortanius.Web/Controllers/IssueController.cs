using System.Threading.Tasks;
using Vortanius.Core.Application.Interfaces;
using Vortanius.Core.Domain.Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Vortanius.Web.Controllers
{
    [Route("[controller]")]
    public class IssuesController : BaseController
    {
        private readonly IIssuesApplicationService issuesApplicationService;

        public IssuesController(
            IIssuesApplicationService issueApplicationService) 
        {
            this.issuesApplicationService = issueApplicationService;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> RegisterAsync([FromBody]IssueCreateDto issueCreateDto)
        {
            var result = await issuesApplicationService.RegisterAsync(issueCreateDto);

            return HandleResult(result);
        }
    }
}