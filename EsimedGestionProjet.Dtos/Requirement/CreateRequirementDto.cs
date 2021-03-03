using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimedGestionProjet.Dtos
{
    public record CreateRequirementDto
    {
        [Required]
        public string Description { get; init; }

        [Required]
        public bool IsFunctional { get; init; }

        public string RequirementNoneFunctional { get; init; }

        [Required]
        public Guid Project { get; set; }
    }
}
