using ProjectNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNote.Repositories
{
    public class Repository
    {
        internal void AddNewUser(string name,string password,string greenfoxClass)
        {
            User newUser = new User();
            newUser.name = name;
            newUser.password = password;
            newUser.greenfoxClass = greenfoxClass;
        }
    }
}
