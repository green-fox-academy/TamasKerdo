using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpdatedToDo.Entities;

namespace UpdatedToDo.Repositories
{
    public class Repository
    {
        public ToDoContext ToDoContext { get; set; }

        public Repository(ToDoContext ToDoContext)
        {
            this.ToDoContext = ToDoContext;
        }
    }
}
