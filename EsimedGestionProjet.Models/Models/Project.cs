using System;
using System.Collections.Generic;
using System.Text;

namespace EsimedGestionProjet.Models
{
    public record Project
    {
        public Guid Id { get; init; }

        public string Name { get; init; }

        public User User { get; init; }

        public List<Requirement> Requirements { get; init; }

        public List<Task> Tasks { get; init; }

        public List<Milestone> Milestones { get; init; }

        public DateTime StartDate { get; init; }

        public DateTime EndDateTheorical { get; init; }

        public DateTime? EndDateReal { get; init; }
    }
}
