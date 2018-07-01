using Microsoft.EntityFrameworkCore;
using ProjectNote.Models;

namespace ProjectNote.Entities
{
    public class ProjectNoteContext : DbContext
    {
        public ProjectNoteContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(x => x.Projects)
                .WithOne(x => x.User)
                .HasPrincipalKey(x => x.UserId);
        }
    }
}
