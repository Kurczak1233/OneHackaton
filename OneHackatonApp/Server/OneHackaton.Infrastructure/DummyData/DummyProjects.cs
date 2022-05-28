using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.DummyData
{
    public class DummyProjects
    {
        public static List<Project> GetProjects()
        {
            List<Project> projects = new List<Project>();

            var project1 = new Project()
            {
                Id = 6,
                Name = "HealthCare Application",
                TeamId = 2
            };
            var project2 = new Project()
            {
                Id = 7,
                Name = "Media Application",
                TeamId = 2
            };


            projects.Add(project1);
            projects.Add(project2);

            return projects;
        }
    }
}
