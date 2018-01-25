using Microsoft.EntityFrameworkCore;
using ProjectNote.Entities;
using ProjectNote.Models;
using System.Collections.Generic;
using System.Linq;

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
            newUser.Name = name;
            newUser.Password = password;
            newUser.GreenfoxClass = greenfoxClass;
            PNC.Users.Add(newUser);
            PNC.SaveChanges();
        }        

        public bool Verify(string name, string password)
        {
            User searchedUser = PNC.Users.FirstOrDefault(x => x.Name == name);

            if (searchedUser!=null)
            {
                if (searchedUser.Password.Equals(password))
                {                    
                    return true;
                }
            }
            return false;
        }

        public void AddNewProject(Project json, long UserId)
        {            
            User user = PNC.Users.FirstOrDefault(u=>u.UserId == UserId);
            user.Projects.Add(json);
            PNC.SaveChanges();
        }

        internal long? GetUser(string name, string password)
        {
            long? id = PNC.Users.FirstOrDefault(u => u.Name == name).UserId;
            return id;
        }

        public List<ProjectWithoutConnection> Search(string word, bool location, string language, long userId)
        {
            var projectWithoutConnectionList = new List<ProjectWithoutConnection>();
            PNC.Users.Load();
            PNC.Projects.Load();
            if (location)
            {
                foreach (var project in PNC.Projects)
                {
                    if ((project.Description.Contains(word)) && (project.ProgrammingLanguage == language))
                    {
                        projectWithoutConnectionList.Add(ProjectCopier(project));
                    }
                }
            }
            else
            {
                foreach (var user in PNC.Users)
                {
                    foreach (var project in user.Projects)
                    {
                        if ((project.Name == word||project.Description.Contains(word))&&project.ProgrammingLanguage ==language)
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
            projectWithoutConnection.Name = projectToCopy.Name;
            projectWithoutConnection.Description = projectToCopy.Description;
            projectWithoutConnection.Link = projectToCopy.Link;
            projectWithoutConnection.ProgrammingLanguage = projectToCopy.ProgrammingLanguage;
            projectWithoutConnection.UserName = projectToCopy.User.Name.ToString();
            return projectWithoutConnection;
        }
    }
}
