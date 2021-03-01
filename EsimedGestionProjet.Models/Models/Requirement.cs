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
        public string description { get; init; }

        [Required]
        public bool isFunctional { get; init; }

        public string RequirementNoneFunctional { get; init; }

        public List<Task> Tasks { get; init; }

        [Required]
        public Project project { get; set; }
    }
}
