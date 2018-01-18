using Reddit.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repositories
{
    public class Repository
    {
        public PostContext PC { get; set; }

        public Repository(PostContext postContext)
        {
            PC = postContext;
        }
    }
}
