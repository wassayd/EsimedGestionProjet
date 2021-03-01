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
        public string Label { get; init; }

        [Required]
        public string description { get; init; }

        [Required]
        public User User { get; init; }

        public List<Requirement> Requirements { get; init; } // pas obliger

        public DateTime RealStartDate { get; init; } //start Date

        [Required]
        public DateTime TheoricDateStart { get; init; }

        [Required]
        public float NbDay { get; init; } // charge

        [Required]
        public Project project { get; set; }

        public Milestone Milestone { get; init; } // pas obliger

    }
}
