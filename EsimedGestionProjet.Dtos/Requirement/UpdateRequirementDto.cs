using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimedGestionProjet.Dtos
{
    public record UpdateRequirementDto
    {
        public string Description { get; init; }

        public bool IsFunctional { get; init; }

        public string RequirementNoneFunctional { get; init; }
    }
}
