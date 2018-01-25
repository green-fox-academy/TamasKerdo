using ProjectNote.Entities;
using ProjectNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNote.Repositories
{
    public class Repository
    {
        public ProjectNoteContext PNC { get; set; }
        public User loggedInUser { get; set; }

        public Repository(ProjectNoteContext PNC, User loggedInUser)
        {
            this.PNC = PNC;
            this.loggedInUser = loggedInUser;
        }

        public void AddNewUser(string name,string password,string greenfoxClass)
        {
            User newUser = new User();
            newUser.name = name;
            newUser.password = password;
            newUser.greenfoxClass = greenfoxClass;
            PNC.users.Add(newUser);
            PNC.SaveChanges();
        }        

        public bool Verify(string name, string password)
        {
            User searchedUser = PNC.users.FirstOrDefault(x => x.name == name);

            if (searchedUser!=null)
            {
                if (searchedUser.password.Equals(password))
                {
                    loggedInUser = searchedUser;
                    return true;
                }
            }
            return false;
        }

        public void AddNewProject(string link, string projectName, string description, string language)
        {
            var newProject = new Project();
            newProject.name = projectName;
            newProject.link = link;
            newProject.description = description;
            newProject.programmingLanguage = language;

            loggedInUser.projects.Add(newProject);
            PNC.SaveChanges();
        }

        public List<Project> Search(string word, bool location, string language)
        {
            var projectList = new List<Project>();
            if (location)
            {
                PNC.Entry(loggedInUser).Collection(u => u.projects).Load();
                foreach (var project in PNC.projects)
                {
                    if ((project.description.Contains(word)) && (project.programmingLanguage == language))
                    {
                        projectList.Add(project);
                    }
                }
            }
            else
            {
                
            }
            return projectList;
        }
    }
}
