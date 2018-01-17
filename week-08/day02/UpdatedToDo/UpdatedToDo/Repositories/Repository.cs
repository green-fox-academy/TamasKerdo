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

        public static List<ToDo> ToDoToList { get; set; } = new List<ToDo>();

        public Repository(ToDoContext ToDoContext)
        {
            this.ToDoContext = ToDoContext;
        }

        public ToDo GetToDo(int id)
        {
            ToDo todoToGet = ToDoContext.ToDos.FirstOrDefault(x => x.Id == id);
            return todoToGet;
        }

        public void AddNewToDo(ToDo newTodo)
        {            
            ToDoContext.ToDos.Add(newTodo);
            ToDoContext.SaveChanges();
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

        public void DeleteToDo(int id)
        {
            ToDo todoToDelete = ToDoContext.ToDos.FirstOrDefault(x => x.Id == id);
            ToDoContext.ToDos.Remove(todoToDelete);
            ToDoContext.SaveChanges();
        }

        public void EditToDo(ToDo newtodo)
        {            
            ToDoContext.ToDos.Update(newtodo);
            ToDoContext.SaveChanges();
        }
    }
}
