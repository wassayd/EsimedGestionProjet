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
                Milestones = project.Milestones.Select(x => x.AsDto()).ToList(),
                Requirements = project.Requirements.Select(x=> x.AsDto()).ToList(),
                StartDate = project.StartDate,
                Tasks = project.Tasks.Select(t => t.AsDto()).ToList(),
                User = project.User.AsDto()
            };
        }

        public static MilestoneDto AsDto(this Milestone milestone)
        {
            return new MilestoneDto
            {
                Id = milestone.Id,
                Label = milestone.Label,
                DeleveryDateEstimated = milestone.DeleveryDateEstimated,
                Project = milestone.Project.AsDto(),
                RealDateEstimated = milestone.RealDateEstimated,
                Tasks = milestone.Tasks.Select(t => t.AsDto()).ToList(),
                User = milestone.User.AsDto()
            };
        }

        public static TaskDto AsDto(this Models.Task task)
        {
            return new TaskDto
            {
                Id = task.Id,
                Requirements = task.Requirements.Select(r => r.Id).ToList(),
                Description = task.Description,
                Label = task.Label,
                Milestone = task.Milestone?.Id,
                NbDay = task.NbDay,
                Project = task.Project.Id,
                User = task.User.AsDto()
            };
        }

        public static UserDto AsDto(this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Trigram = user.Trigram
            };
        }

        public static RequirementDto AsDto(this Requirement requirement)
        {
            return new RequirementDto
            {
                Id = requirement.Id,
                Description = requirement.Description,
                isFunctional = requirement.IsFunctional,
                Project = requirement.Project.Id,
                RequirementNoneFunctional = requirement.RequirementNoneFunctional,
                Tasks = requirement.Tasks.Select(x => x.AsDto()).ToList()
            };
        }
    }
}
