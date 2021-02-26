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
                Id = 1,
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
                Id = 2,
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

        public IEnumerable<Project> GetAll()
        {
            return projects;
        }

        public Project GetById(int id)
        {
            return projects.Where(project => project.Id == id).SingleOrDefault();
        }
    }
}
