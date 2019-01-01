using System.Threading.Tasks;
using Vortanius.Core.Domain.Entities.Dto;

namespace Vortanius.Core.Domain.Interfaces
{
    public interface IIssuesDomainService
    {
         Task<IssueDto> CreateAsync(IssueCreateDto issueCreateDto);
    }
}