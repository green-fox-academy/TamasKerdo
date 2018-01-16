using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpdatedToDo.Entities;
using UpdatedToDo.Models;

namespace UpdatedToDo.Repositories
{
    public class Repository
    {
        public ToDoContext ToDoContext { get; set; }

        public Repository(ToDoContext ToDoContext)
        {
            this.ToDoContext = ToDoContext;
        }

        public void AddNewToDo(ToDo newTodo)
        {
            ToDo todo = newTodo;
            ToDoContext.ToDos.Add(todo);            
        }

        public List<ToDo> ListAllToDo()
        {
            var todoList = ToDoContext.ToDos.ToList();
            return todoList;
        }

        public List<ToDo> ListFinishedToDos()
        {
            var todoList = ToDoContext.ToDos.Where(x=>x.isDone== true).ToList();
            return todoList;
        }

        public List<ToDo> ListUnFinishedToDos()
        {
            var todoList = ToDoContext.ToDos.Where(x => x.isDone == false).ToList();
            return todoList;
        }
    }
}
