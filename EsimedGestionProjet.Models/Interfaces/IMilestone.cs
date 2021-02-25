using System;
using System.Collections.Generic;

namespace EsimedGestionProjet.Models.Interfaces
{
    public interface IMilestone
    {
        int Id { get; set; }

        List<ITask> Tasks { get; set; }

        bool IsFinished();

        string Label { get; set; }

        DateTime DeleveryDateEstimated { get; set; }

        DateTime RealDateEstimated { get; set; }

        IUser User { get; set; }

        DateTime TheoricCalculatedDate { get; set; }

        IProject Project { get; set; }

    }
}