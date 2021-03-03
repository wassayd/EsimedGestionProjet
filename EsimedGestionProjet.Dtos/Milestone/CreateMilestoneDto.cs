using EsimedGestionProjet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimedGestionProjet.Dtos
{
    public record CreateMilestoneDto
    {
        public string Label { get; init; }

        public DateTime DeleveryDateEstimated { get; init; }

        public Guid UserId { get; init; }

        public Guid ProjectId { get; init; }
    }
}
