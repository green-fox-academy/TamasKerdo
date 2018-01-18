using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Entities
{
    public class PostContext
    {
        public DbSet<Post> MyProperty { get; set; }
    }
}
