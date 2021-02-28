using EsimedGestionProjet.Models;
using System;
using System.Collections.Generic;

namespace EsimedGestionProjet.Dtos
{
    public record ProjectDto
    {
        public Guid Id { get; init; }

        public string Name { get; init; }

        public User User { get; init; }

        public List<Requirement> Requirements { get; init; }

        public List<Models.Task> Tasks { get; init; }

        public List<Milestone> Milestones { get; init; }

        public DateTime StartDate { get; init; }

        public DateTime EndDateTheorical { get; init; }

        public DateTime? EndDateReal { get; init; }
    }
}
