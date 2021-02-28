using System;
using System.Collections.Generic;
using System.Text;

namespace EsimedGestionProjet.Models
{
    public record Task
    {
        public Guid Id { get; init; }

        public string Label { get; init; }

        public string description { get; init; }

        public User User { get; init; }

        public List<Requirement> Requirements { get; init; }

        public DateTime StartDate { get; init; }

        public float NbDay { get; init; }

        public Milestone Milestone { get; init; }

        public Progression Progression { get; init; }
    }
}
