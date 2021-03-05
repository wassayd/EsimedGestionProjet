using EsimedGestionProjet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimedGestionProjet.Dtos
{
    public record UpdateTaskDto
    {
        public string Label { get; init; }

        public string Description { get; init; }
        
        public Guid UserId { get; init; }

        public List<Guid> Requirements { get; init; } = new(); // pas obliger

        public DateTime TheoricDateStart { get; init; }

        public float NbDay { get; init; } // charge

        public Guid Milestone { get; init; } // pas obliger
    }
}
