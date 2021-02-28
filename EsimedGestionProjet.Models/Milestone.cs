using System;
using System.Collections.Generic;
using System.Text;

namespace EsimedGestionProjet.Models
{
    public record Milestone 
    {
        public Guid Id { get; init; }

        public List<Task> Tasks { get; init; }

        public string Label { get; init; }

        public DateTime DeleveryDateEstimated { get; init; }

        public DateTime RealDateEstimated { get; init; }

        public User User { get; init; }

        public DateTime TheoricCalculatedDate { get; init; }

        public Project Project { get; init; }

        public bool IsFinished()
        {
            return false;
        }
    }
}
