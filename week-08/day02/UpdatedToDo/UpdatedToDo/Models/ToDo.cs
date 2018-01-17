using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpdatedToDo.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string title { get; set; }
        public bool isDone { get; set; }
        public bool isUrgent { get; set; }
        public User person { get; set; }
    }
}
