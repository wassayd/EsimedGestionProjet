using EsimedGestionProjet.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsimedGestionProjet.Models
{
    public record Milestone : IMilestone
    {
        public int Id { get; init; }

        public List<ITask> Tasks { get; init; }

        public string Label { get; init; }

        public DateTime DeleveryDateEstimated { get; init; }

        public DateTime RealDateEstimated { get; init; }

        public IUser User { get; init; }

        public DateTime TheoricCalculatedDate { get; init; }

        public IProject Project { get; init; }

        public bool IsFinished()
        {
            return false;
        }
    }
}
