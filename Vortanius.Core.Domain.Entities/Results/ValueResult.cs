using System;
using System.Collections.Generic;
using Vortanius.Core.Domain.Entities.Enums;

namespace Vortanius.Core.Domain.Entities.Results
{
    public class ValueResult<TData, TError> : IApplicationResult<TData, TError>
        where TData : class
    {
        public ValueResult(StatusEnum status, TData data)
        {
            Status = status;
            Data = data;
        }

        public StatusEnum Status { get; private set; }
        
        public TData Data { get; private set; }

        public IEnumerable<TError> ValidationErrors => new List<TError>();
    }
}