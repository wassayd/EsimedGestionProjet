using EsimedGestionProjet.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsimedGestionProjet.Models
{
    class Requirement : IRequirement
    {
        public int Id { get; set; }
        public string description { get; set; }
        public bool isFunctional { get; set; }
        public string RequirementNoneFunctional { get; set; }
        public List<ITask> Tasks { get; set; }
    }
}
