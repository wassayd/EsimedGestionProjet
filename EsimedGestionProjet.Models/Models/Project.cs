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
        public string Name { get; set; }

        [Required]
        public User User { get; set; } // le chef de projet ?

        public List<Requirement> Requirements { get; set; } = new();

        public List<Task> Tasks { get; set; } = new();

        public List<Milestone> Milestones { get; set; } = new();

        public DateTime StartDate { get; set; } = DateTime.Now;
        
        
        public DateTime? EndDateTheorical { get; set; }

        public DateTime? EndDateReal { get; set; }
    }
}
