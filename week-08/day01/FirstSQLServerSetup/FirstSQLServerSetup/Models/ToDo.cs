﻿using System.ComponentModel.DataAnnotations.Schema;


namespace FirstSQLServerSetup.Models
{
    public class ToDo
    { 
        public long Id { get; set; }
        public string Title { get; set; }
        public bool IsUrgent { get; set; } = false;
        public bool IsDone { get; set; } = false;
    }
}
