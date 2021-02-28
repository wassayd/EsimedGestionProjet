﻿using EsimedGestionProjet.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsimedGestionProjet.Services.CustomAttributes;

namespace EsimedGestionProjet.Dtos
{
    
    public record UpdateProjectDto 
    {

        [Required]
        public string Name { get; init; }

        [Required]
        [MinDate]
        public DateTime? EndDateTheorical { get; init; }
    }
}