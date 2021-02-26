using System;
using System.Collections.Generic;

namespace EsimedGestionProjet.Models.Interfaces
{
    public interface ITask
    {
        int Id { get; init; }

        string Label { get; init; }

        string description { get; init; }

        IUser User { get; init; }

        List<IRequirement> Requirements { get; init; }

        DateTime StartDate { get; init; }

        float NbDay { get; init; }

        IMilestone Milestone { get; init; }

        Progression Progression { get; init; }
    }

    public enum Progression
    {
        Created = 0,
        Inprogress = 50,
        Finished = 100
    }
}