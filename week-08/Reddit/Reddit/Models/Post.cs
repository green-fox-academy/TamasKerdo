using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class Post
    {
        public long PostId { get; set; }
        public string PostContent { get; set; }
        public DateTime TimoeOfThePost { get; set; }
    }
}
