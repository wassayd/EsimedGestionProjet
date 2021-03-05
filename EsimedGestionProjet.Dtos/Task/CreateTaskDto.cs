using EsimedGestionProjet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimedGestionProjet.Dtos
{
    public record CreateTaskDto
    {
        [Required]
        public string Label { get; init; }

        [Required]
        public string Description { get; init; }

        [Required]
        public Guid UserId { get; init; }

        public List<Guid> Requirements { get; init; } = new(); // pas obliger

        [Required]
        public DateTime TheoricDateStart { get; init; }

        [Required]
        public float NbDay { get; init; } // charge

        [Required]
        public Guid Project { get; init; }

        public Guid Milestone { get; init; } // pas obliger

    }
}
