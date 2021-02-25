using System;
using System.Collections.Generic;
using System.Text;

namespace EsimedGestionProjet.Models.Interfaces
{
    public interface IProject
    {
        int Id { get; set; }

        string Name { get; set; }

        IUser User { get; set; }

        List<IRequirement> Requirements { get; set; }

        List<ITask> Tasks { get; set; }

        List<IMilestone> Milestones { get; set; } 

        DateTime StartDate { get; set; }

        DateTime EndDateTheorical { get; set; }

        DateTime EndDateReal { get; set; }

    }
}
