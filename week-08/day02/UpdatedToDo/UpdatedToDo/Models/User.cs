﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpdatedToDo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ToDo> ToDoList { get; set; } = new List<ToDo>();
    }
}
