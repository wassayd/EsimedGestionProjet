using EsimedGestionProjet.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimedGestionProjet.Dtos
{
    public record RequirementDto : IRequirement
    {
        public int Id { get; init; }

        public string description { get; init; }

        public bool isFunctional { get; init; }

        public string RequirementNoneFunctional { get; init; }

        public List<ITask> Tasks { get; init; }
    }
}
