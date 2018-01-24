using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNote.Models
{
    public class User
    {
        [Key]
        public long? userId { get; set; }
        public string name { get; set; }
        public string greenfoxClass { get; set; }
        public IList<Project> projects { get; set; } = new List<Project>();
    }
}
