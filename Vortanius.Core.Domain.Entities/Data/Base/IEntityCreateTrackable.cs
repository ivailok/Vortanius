using System;

namespace Vortanius.Core.Domain.Entities.Data.Base
{
    public interface IEntityCreateTrackable
    {
        DateTime CreatedOn { get; set; }

        string CreatedBy { get; set; }
    }
}