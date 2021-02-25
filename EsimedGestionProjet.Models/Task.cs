using EsimedGestionProjet.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsimedGestionProjet.Models
{
    class Task : ITask
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string description { get; set; }
        public IUser User { get; set; }
        public List<IRequirement> Requirements { get; set; }
        public DateTime StartDate { get; set; }
        public float NbDay { get; set; }
        public IMilestone Milestone { get; set; }
        public Progression Progression { get; set; }
    }
}
