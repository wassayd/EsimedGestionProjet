using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EsimedGestionProjet.Models
{
    public record Task
    {
        public Guid Id { get; init; }
        
        [Required]
        public string Label { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public User User { get; set; }

        public List<Requirement> Requirements { get; set; } // pas obliger

        public DateTime RealStartDate { get; set; } //start Date

        [Required]
        public DateTime TheoricDateStart { get; set; }

        [Required]
        public float NbDay { get; set; } // charge

        [Required]
        public Project Project { get; set; }

        public Milestone Milestone { get; set; } // pas obliger

    }
}
