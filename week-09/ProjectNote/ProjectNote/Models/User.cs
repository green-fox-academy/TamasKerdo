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
        public long? UserId { get; set; }
        public string name { get; set; }
        public string greenfoxClass { get; set; }
    }
}
