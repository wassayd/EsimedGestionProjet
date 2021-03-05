using EsimedGestionProjet.Models;
using System;
using System.Collections.Generic;

namespace EsimedGestionProjet.Dtos
{
    public record ProjectDto
    {
        public Guid Id { get; init; }

        public string Name { get; set; }

        public UserDto User { get; set; } // le chef de projet ?

        public List<RequirementDto> Requirements { get; set; } = new();

        public List<TaskDto> Tasks { get; set; } = new();

        public List<MilestoneDto> Milestones { get; set; } = new();

        public DateTime StartDate { get; set; } = DateTime.Now;

        public DateTime? EndDateTheorical { get; set; }

        public DateTime? EndDateReal { get; set; }
    }
}
