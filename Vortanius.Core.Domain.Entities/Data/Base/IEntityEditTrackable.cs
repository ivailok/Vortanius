using System;

namespace Vortanius.Core.Domain.Entities.Data.Base
{
    public interface IEntityEditTrackable
    {
        DateTime? ModifiedOn { get; set; }

        string ModifiedBy { get; set; }
    }
}