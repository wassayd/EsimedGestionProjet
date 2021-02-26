using System;
using System.Collections.Generic;

namespace EsimedGestionProjet.Models.Interfaces
{
    public interface IMilestone
    {
        int Id { get; init; }

        List<ITask> Tasks { get; init; }

        bool IsFinished();

        string Label { get; init; }

        DateTime DeleveryDateEstimated { get; init; }

        DateTime RealDateEstimated { get; init; }

        IUser User { get; init; }

        DateTime TheoricCalculatedDate { get; init; }

        IProject Project { get; init; }

    }
}