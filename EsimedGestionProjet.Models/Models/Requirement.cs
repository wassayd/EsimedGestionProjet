using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EsimedGestionProjet.Models
{
    public record Requirement
    {
        public Guid Id { get; init; }

        [Required]
        public string Description { get; set; }

        [Required]
        public bool IsFunctional { get; set; }

        public string RequirementNoneFunctional { get; set; }

        public List<Task> Tasks { get; set; }

        [Required]
        public Project Project { get; set; }
    }
}
