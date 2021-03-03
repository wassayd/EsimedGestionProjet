using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsimedGestionProjet.Models;
using EsimedGestionProjet.Services.CustomAttributes;

namespace EsimedGestionProjet.Dtos
{
    
    public record CreateProjectDto
    {

        [Required]
        public string Name { get; init; }

        [Required]
        public Guid UserId { get; init; }

        //[Required]
        //[MinDate]
        //public DateTime EndDateTheorical { get; init; }
    }
}
