﻿using System.ComponentModel.DataAnnotations;

namespace ProjectNote.Models
{
    public class Project
    {
        [Key]
        public long? ProjectId { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }        
        public string ProgrammingLanguage { get; set; }
        public User User { get; set; }
    }
}
