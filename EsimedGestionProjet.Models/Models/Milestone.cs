using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EsimedGestionProjet.Models
{
    public record Milestone 
    {
        public Guid Id { get; init; }

        public List<Task> Tasks { get; init; }

        [Required]
        public string Label { get; init; }

        public DateTime DeleveryDateEstimated { get; init; }

        public DateTime RealDateEstimated { get; init; }

        [Required]
        public User User { get; init; }

        public DateTime TheoricCalculatedEndDate { get; init; }

        [Required]
        public Project Project { get; init; }

        public Progression Progression { get; init; }

        public bool IsFinished()
        {
            return false;
        }
    }
}
