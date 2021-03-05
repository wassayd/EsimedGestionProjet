using EsimedGestionProjet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimedGestionProjet.Dtos
{
    public record TaskDto
    {
        public Guid Id { get; init; }

        public string Label { get; init; }

        public string Description { get; init; }

        public UserDto User { get; init; }

        public List<Guid> Requirements { get; init; } = new(); // pas obliger

        public DateTime RealStartDate { get; init; } //start Date

        public DateTime TheoricDateStart { get; init; }

        public float NbDay { get; init; } // charge

        public Guid Project { get; set; }

        public Guid? Milestone { get; set; } // pas obliger
    }
}
