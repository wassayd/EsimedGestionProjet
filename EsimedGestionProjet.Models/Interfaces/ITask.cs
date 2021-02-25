using System;
using System.Collections.Generic;

namespace EsimedGestionProjet.Models.Interfaces
{
    public interface ITask
    {
        int Id { get; set; }

        string Label { get; set; }

        string description { get; set; }

        IUser User { get; set; }

        List<IRequirement> Requirements { get; set; }

        DateTime StartDate { get; set; }

        float NbDay { get; set; }

        IMilestone Milestone { get; set; }

        Progression Progression { get; set; }
    }

    public enum Progression
    {
        Created = 0,
        Inprogress = 50,
        Finished = 100
    }
}