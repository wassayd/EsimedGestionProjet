using EsimedGestionProjet.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsimedGestionProjet.Models
{
    class Project : IProject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IUser User { get; set; }
        public List<IRequirement> Requirements { get; set; }
        public List<ITask> Tasks { get; set; }
        public List<IMilestone> Milestones { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDateTheorical { get; set; }
        public DateTime EndDateReal { get; set; }
    }
}
