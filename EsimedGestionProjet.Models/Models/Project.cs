using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EsimedGestionProjet.Models
{
    public record Project
    {
        public Guid Id { get; init; }

        [Required]
        [MaxLength(200)]
        public string Name { get; init; }

        [Required]
        public User User { get; init; } // le chef de projet ?

        public List<Requirement> Requirements { get; init; }

        public List<Task> Tasks { get; init; }

        public List<Milestone> Milestones { get; init; }

        public DateTime StartDate { get; init; } = DateTime.Now;
        
        [Required]
        public DateTime EndDateTheorical { get; init; }

        public DateTime? EndDateReal { get; init; }
    }
}
