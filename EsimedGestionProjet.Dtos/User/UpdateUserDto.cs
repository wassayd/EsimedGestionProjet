using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimedGestionProjet.Dtos
{
    public record UpdateUserDto
    {
        public string FirstName { get; init; }

        public string LastName { get; init; }

        public string Trigram { get; init; }
    }
}
