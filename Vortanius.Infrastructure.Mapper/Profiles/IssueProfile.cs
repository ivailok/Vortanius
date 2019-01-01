using AutoMapper;
using Vortanius.Core.Domain.Entities.Data.Dbo;
using Vortanius.Core.Domain.Entities.Dto;

namespace Vortanius.Infrastructure.Mapper.Profiles
{
    public class IssueProfile : Profile
    {
        public IssueProfile()
        {
            CreateMap<IssueCreateDto, Issue>();
            CreateMap<Issue, IssueDto>();
        }
    }
}