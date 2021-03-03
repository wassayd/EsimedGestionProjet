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
    
    public record UpdateProjectDto
    {
        public string Name { get; init; }
      
        public Guid UserId { get; init; }
    }
}
