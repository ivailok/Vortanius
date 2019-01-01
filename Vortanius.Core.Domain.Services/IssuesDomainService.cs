using System.Threading.Tasks;
using Vortanius.Core.Domain.Entities.Data.Dbo;
using Vortanius.Core.Domain.Entities.Dto;
using Vortanius.Core.Domain.Interfaces;
using Vortanius.Core.Interfaces.Data;
using Vortanius.Core.Interfaces.Data.Repositories.Dbo;
using Vortanius.Core.Interfaces.Mapper;

namespace Vortanius.Core.Domain.Services
{
    public class IssuesDomainService : IIssuesDomainService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IIssuesRepository issuesRepository;
        private readonly IMapperService mapperService;

        public IssuesDomainService(
            IUnitOfWork unitOfWork,
            IIssuesRepository issuesRepository,
            IMapperService mapperService)
        {
            this.unitOfWork = unitOfWork;
            this.issuesRepository = issuesRepository;
            this.mapperService = mapperService;
        }

        public async Task<IssueDto> CreateAsync(IssueCreateDto issueCreateDto)
        {
            var issue = mapperService.Map<Issue>(issueCreateDto);
            
            this.issuesRepository.Add(issue);
            await this.unitOfWork.CompleteAsync();

            var issueDto = mapperService.Map<IssueDto>(issue);

            return issueDto;
        }
    }
}