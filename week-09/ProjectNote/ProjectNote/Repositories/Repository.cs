using Microsoft.EntityFrameworkCore;
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

        public Repository(ProjectNoteContext PNC)
        {
            this.PNC = PNC;
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
                    return true;
                }
            }
            return false;
        }

        public void AddNewProject(Project json, long UserId)
        {
            //var newProject = new Project();
            //newProject.name = json.name;
            //newProject.link = json.link;
            //newProject.description = json.description;
            //newProject.programmingLanguage = json.programmingLanguage;
            User user = PNC.users.FirstOrDefault(u=>u.userId == UserId);
            user.projects.Add(json);
            PNC.SaveChanges();
        }

        internal long? GetUser(string name, string password)
        {
            long? id = PNC.users.FirstOrDefault(u => u.name == name).userId;
            return id;
        }

        public List<ProjectWithoutConnection> Search(string word, bool location, string language, long userId)
        {
            var projectWithoutConnectionList = new List<ProjectWithoutConnection>();
            PNC.users.Load();
            PNC.projects.Load();
            if (location)
            {
                var user = PNC.users.FirstOrDefault(u => u.userId == userId);
                //PNC.Entry(user).Collection(u => u.projects).Load();
                
                foreach (var project in PNC.projects)
                {
                    if ((project.description.Contains(word)) && (project.programmingLanguage == language))
                    {
                        projectWithoutConnectionList.Add(ProjectCopier(project));
                    }
                }
            }
            else
            {
                foreach (var user in PNC.users)
                {
                    foreach (var project in user.projects)
                    {
                        if ((project.name == word||project.description.Contains(word))&&project.programmingLanguage ==language)
                        {
                            projectWithoutConnectionList.Add(ProjectCopier(project));
                        }
                    }
                }
            }
            return projectWithoutConnectionList;
                        
        }

        public ProjectWithoutConnection ProjectCopier(Project projectToCopy)
        {
            var projectWithoutConnection = new ProjectWithoutConnection();
            projectWithoutConnection.name = projectToCopy.name;
            projectWithoutConnection.description = projectToCopy.description;
            projectWithoutConnection.link = projectToCopy.link;
            projectWithoutConnection.programmingLanguage = projectToCopy.programmingLanguage;
            projectWithoutConnection.userName = projectToCopy.user.name.ToString();
            return projectWithoutConnection;
        }
    }
}
