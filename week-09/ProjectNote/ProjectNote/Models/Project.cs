using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNote.Models
{
    public class Project
    {
        [Key]
        public long? projectId { get; set; }
        public string link { get; set; }
        public string description { get; set; }
        public string programmingLanguage { get; set; }
    }
}
