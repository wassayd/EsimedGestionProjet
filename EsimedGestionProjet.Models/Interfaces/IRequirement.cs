using System.Collections.Generic;

namespace EsimedGestionProjet.Models.Interfaces
{
    public interface IRequirement
    {
        int Id { get; init; }

        string description { get; init; }

        bool isFunctional { get; init; }

        string RequirementNoneFunctional { get; init; }
        
        List<ITask> Tasks { get; init; }
    }
}