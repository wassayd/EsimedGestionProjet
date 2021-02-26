using System;
using System.Collections.Generic;
using System.Text;

namespace EsimedGestionProjet.Models.Interfaces
{
    public interface IProject
    {
        int Id { get; init; }

        string Name { get; init; }

        IUser User { get; init; }

        List<IRequirement> Requirements { get; init; }

        List<ITask> Tasks { get; init; }

        List<IMilestone> Milestones { get; init; } 

        DateTime StartDate { get; init; }

        DateTime EndDateTheorical { get; init; }

        DateTime EndDateReal { get; init; }

    }
}
