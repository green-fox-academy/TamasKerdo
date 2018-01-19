using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Reddit.Models
{
    public class Post
    {
        public long PostId { get; set; }
        public string PostContent { get; set; }       
        public long? Opinion { get; set; }
        public DateTime TimoeOfThePost { get; set; }       
    }
}
