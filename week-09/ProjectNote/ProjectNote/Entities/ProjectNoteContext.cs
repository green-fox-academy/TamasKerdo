using Microsoft.EntityFrameworkCore;
using ProjectNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNote.Entities
{
    public class ProjectNoteContext : DbContext
    {
        public ProjectNoteContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Project> projects { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(x => x.projects)
                .WithOne(x => x.user)
                .HasPrincipalKey(x => x.userId);
        }
    }
}
