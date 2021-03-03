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

        public List<Requirement> Requirements { get; set; }

        public List<Task> Tasks { get; set; }

        public List<Milestone> Milestones { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;
        
        [Required]
        public DateTime EndDateTheorical { get; set; }

        public DateTime? EndDateReal { get; set; }
    }
}
