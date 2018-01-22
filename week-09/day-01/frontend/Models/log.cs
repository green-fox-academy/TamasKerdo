using System;
using System.ComponentModel.DataAnnotations;

namespace Frontend.Models
{
    public class Log
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Endpoint { get; set; }
        public string Data { get; set; }
    }
}
