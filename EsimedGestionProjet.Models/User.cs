using EsimedGestionProjet.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsimedGestionProjet.Models
{
    public record User : IUser
    {
        public int Id { get; init; }

        public string FirstName { get; init; }

        public string LastName { get; init; }

        public string trigram { get; init; }
    }
}
