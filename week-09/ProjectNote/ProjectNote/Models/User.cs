using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectNote.Models
{
    public class User
    {
        [Key]
        public long? UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string GreenfoxClass { get; set; }
        
        public IList<Project> Projects { get; set; } = new List<Project>();
    }
}
