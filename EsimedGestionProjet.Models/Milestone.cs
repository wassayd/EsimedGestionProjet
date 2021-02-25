using EsimedGestionProjet.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsimedGestionProjet.Models
{
    class Milestone : IMilestone
    {
        public int Id { get; set; }
        public List<ITask> Tasks { get; set; }
        public string Label { get; set; }
        public DateTime DeleveryDateEstimated { get; set; }
        public DateTime RealDateEstimated { get; set; }
        public IUser User { get; set; }
        public DateTime TheoricCalculatedDate { get; set; }
        public IProject Project { get; set; }

        public bool IsFinished()
        {
            return false;
        }
    }
}
