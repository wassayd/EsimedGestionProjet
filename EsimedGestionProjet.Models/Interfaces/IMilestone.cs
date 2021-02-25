using System;
using System.Collections.Generic;

namespace GestionProjet.Models.Interfaces
{
    public interface IMilestone
    {
        int Id { get; set; }

        List<ITask> Tasks { get; set; }

        bool IsFinished { get; set; }

        string label { get; set; }

        DateTime DeleveryDateEstimated { get; set; }

        DateTime RealDateEstimated { get; set; }

        IUser user { get; set; }

        DateTime TheoricCalculatedDate { get; set; }

        IProject Project { get; set; }

    }
}