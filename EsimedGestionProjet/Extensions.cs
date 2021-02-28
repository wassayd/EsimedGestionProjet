using EsimedGestionProjet.Dtos;
using EsimedGestionProjet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsimedGestionProjet
{
    public static class Extensions
    {

        public static ProjectDto AsDto(this Project project)
        {
            return new ProjectDto
            {
                Id = project.Id,
                Name = project.Name,
                EndDateReal = project.EndDateReal,
                EndDateTheorical = project.EndDateTheorical,
                Milestones = project.Milestones,
                Requirements = project.Requirements,
                StartDate = project.StartDate,
                Tasks = project.Tasks,
                User = project.User
            };
        }
    }
}
