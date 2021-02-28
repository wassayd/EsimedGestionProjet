using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimedGestionProjet.Dtos
{
    public record RequirementDto
    {
        public Guid Id { get; init; }

        public string description { get; init; }

        public bool isFunctional { get; init; }

        public string RequirementNoneFunctional { get; init; }

        public List<Models.Task> Tasks { get; init; }
    }
}
