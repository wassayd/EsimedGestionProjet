using System;
using System.Collections.Generic;
using System.Text;

namespace EsimedGestionProjet.Models
{
    public record Requirement
    {
        public Guid Id { get; init; }

        public string description { get; init; }

        public bool isFunctional { get; init; }

        public string RequirementNoneFunctional { get; init; }

        public List<Task> Tasks { get; init; }
    }
}
