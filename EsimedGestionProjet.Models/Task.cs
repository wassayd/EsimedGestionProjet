using EsimedGestionProjet.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsimedGestionProjet.Models
{
    public record Task : ITask
    {
        public int Id { get; init; }

        public string Label { get; init; }

        public string description { get; init; }

        public IUser User { get; init; }

        public List<IRequirement> Requirements { get; init; }

        public DateTime StartDate { get; init; }

        public float NbDay { get; init; }

        public IMilestone Milestone { get; init; }

        public Progression Progression { get; init; }
    }
}
