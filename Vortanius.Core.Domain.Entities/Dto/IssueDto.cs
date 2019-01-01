using System;

namespace Vortanius.Core.Domain.Entities.Dto
{
    public class IssueDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; } 

        public DateTime CreatedOn { get; set; }
    }
}