using System;
using System.Threading.Tasks;
using Vortanius.Core.Application.Interfaces;
using Vortanius.Core.Domain.Entities.Data.Dbo;
using Vortanius.Core.Domain.Entities.Dto;
using Vortanius.Core.Domain.Entities.Enums;
using Vortanius.Core.Domain.Entities.Results;
using Vortanius.Core.Domain.Interfaces;
using Vortanius.Core.Interfaces.Mapper;

namespace Vortanius.Core.Application.Services
{
    public class IssuesApplicationService : BaseApplicationService, IIssuesApplicationService
    {
        private readonly IIssuesDomainService issuesDomainService;
        private readonly IMapperService mapperService;

        public IssuesApplicationService(
            IIssuesDomainService issuesDomainService,
            IMapperService mapperService)
        {
            this.issuesDomainService = issuesDomainService;
            this.mapperService = mapperService;
        }

        public async Task<IApplicationResult<IssueDto, Enum>> RegisterAsync(IssueCreateDto issueCreateDto)
        {
            if (IsInvalidRequest(issueCreateDto, out IApplicationResult<IssueDto, Enum> result))
            {
                return result;
            }

            var issueDto = await issuesDomainService.CreateAsync(issueCreateDto);

            return new ValueResult<IssueDto, Enum>(StatusEnum.EntityCreated, issueDto);
        }
    }
}
