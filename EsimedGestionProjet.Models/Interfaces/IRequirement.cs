using System.Collections.Generic;

namespace EsimedGestionProjet.Models.Interfaces
{
    public interface IRequirement
    {
        int Id { get; set; }

        string description { get; set; }

        bool isFunctional { get; set; }

        string RequirementNoneFunctional { get; set; }
        
        List<ITask> Tasks { get; set; }
    }
}