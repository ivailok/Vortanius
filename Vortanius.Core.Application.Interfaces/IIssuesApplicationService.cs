using System;
using System.Threading.Tasks;
using Vortanius.Core.Domain.Entities.Dto;
using Vortanius.Core.Domain.Entities.Results;

namespace Vortanius.Core.Application.Interfaces
{
    public interface IIssuesApplicationService
    {
        Task<IApplicationResult<IssueDto, Enum>> RegisterAsync(IssueCreateDto issueCreateDto);
    }
}
