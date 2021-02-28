using EsimedGestionProjet.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimedGestionProjet.Dtos
{
    public record ProjectDto
    {
        public Guid Id { get; init; }

        public string Name { get; init; }

        public IUser User { get; init; }

        public List<IRequirement> Requirements { get; init; }

        public List<ITask> Tasks { get; init; }

        public List<IMilestone> Milestones { get; init; }

        public DateTime StartDate { get; init; }

        public DateTime EndDateTheorical { get; init; }

        public DateTime? EndDateReal { get; init; }
    }
}
