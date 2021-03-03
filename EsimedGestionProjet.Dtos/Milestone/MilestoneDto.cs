using EsimedGestionProjet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimedGestionProjet.Dtos
{
    public record MilestoneDto
    {
        public Guid Id { get; init; }

        public List<TaskDto> Tasks { get; set; }

        public string Label { get; set; }

        public DateTime DeleveryDateEstimated { get; set; }

        public DateTime RealDateEstimated { get; set; }

        public UserDto User { get; set; }

        public DateTime TheoricCalculatedEndDate { get; set; }

        public ProjectDto Project { get; set; }

        public Progression Progression { get; set; } = Progression.Created;

    }
}
