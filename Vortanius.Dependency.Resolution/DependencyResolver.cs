using System;
using Vortanius.Core.Application.Interfaces;
using Vortanius.Core.Application.Services;
using Vortanius.Core.Interfaces.Mapper;
using Vortanius.Infrastructure.Data;
using Vortanius.Infrastructure.Mapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Vortanius.Core.Domain.Interfaces;
using Vortanius.Core.Domain.Services;
using Vortanius.Core.Interfaces.Data;
using Vortanius.Core.Interfaces.Data.Repositories.Dbo;
using Vortanius.Infrastructure.Data.Repositories.Dbo;

namespace Vortanius.Dependency.Resolution
{
    public static class DependencyResolver
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            InitializeLibraries();

            services.AddDbContext<VortaniusDbContext>(opts => opts.UseNpgsql(configuration.GetConnectionString(nameof(VortaniusDbContext))));

            RegisterData(services);
            RegisterDomainServices(services);
            RegisterInfrastructureServices(services);
            RegisterApplicationServices(services);
        }

        private static void InitializeLibraries()
        {
            MapperService.Initialize();
        }

        private static void RegisterApplicationServices(IServiceCollection services)
        {
            services.AddScoped<IIssuesApplicationService, IssuesApplicationService>();
        }

        private static void RegisterDomainServices(IServiceCollection services)
        {
            services.AddScoped<IIssuesDomainService, IssuesDomainService>();
        }

        private static void RegisterInfrastructureServices(IServiceCollection services)
        {
            services.AddScoped<IMapperService, MapperService>();
        }

        private static void RegisterData(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IIssuesRepository, IssuesRepository>();
        }
    }
}
