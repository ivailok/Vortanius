using System.Collections.Generic;
using Vortanius.Core.Domain.Entities.Enums;

namespace Vortanius.Core.Domain.Entities.Results
{
    public interface IApplicationResult
    {
        StatusEnum Status { get; }
    }

    public interface IApplicationResult<TError> : IApplicationResult
    {
        IEnumerable<TError> ValidationErrors { get; }
    }

    public interface IApplicationResult<TData, TError> : IApplicationResult<TError>
        where TData : class
    {   
        TData Data { get; }
    }
}