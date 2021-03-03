using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EsimedGestionProjet.Models
{
    public record User 
    {
        public Guid Id { get; init; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [MaxLength(3)]
        public string Trigram { get; set; }
    }
}
