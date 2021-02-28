using EsimedGestionProjet.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EsimedGestionProjet.Repositories.InMemory
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly List<Project> projects = new()
        {
            new Project
            {
                Id = Guid.NewGuid(),
                Name = "Mon project",
                EndDateReal = DateTime.UtcNow,
                EndDateTheorical = DateTime.UtcNow,
                Milestones = null,
                Requirements = null,
                StartDate = DateTime.UtcNow,
                Tasks = null,
                User = null
            },

            new Project
            {
                Id = Guid.NewGuid(),
                Name = "Mon project 2",
                EndDateReal = DateTime.UtcNow,
                EndDateTheorical = DateTime.UtcNow,
                Milestones = null,
                Requirements = null,
                StartDate = DateTime.UtcNow,
                Tasks = null,
                User = null
            }
        };

        public void Delete(Guid id)
        {
            var index = projects.FindIndex(x => x.Id == id);
            projects.RemoveAt(index);
        }

        public IEnumerable<Project> GetAll()
        {
            return projects;
        }

        public Project GetById(Guid id)
        {
            return projects.Where(project => project.Id == id).SingleOrDefault();
        }

        public void Insert(Project project)
        {
            projects.Add(project);
        }

        public void Update(Project project)
        {
            var index = projects.FindIndex(prj => prj.Id == project.Id);

            projects[index] = project;
        }
    }
}
