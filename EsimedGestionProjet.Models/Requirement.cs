using EsimedGestionProjet.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsimedGestionProjet.Models
{
    public record Requirement : IRequirement
    {
        public int Id { get; init; }

        public string description { get; init; }

        public bool isFunctional { get; init; }

        public string RequirementNoneFunctional { get; init; }

        public List<ITask> Tasks { get; init; }
    }
}
