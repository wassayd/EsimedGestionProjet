using EsimedGestionProjet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimedGestionProjet.Dtos
{
    public record MilestoneDto
    {
        public Guid Id { get; init; }

        public List<Models.Task> Tasks { get; init; }

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
