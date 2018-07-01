using Microsoft.EntityFrameworkCore;
using TripChat.Models;

namespace TripChat.Entities
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Chat> TripChats { get; set; }
        public DbSet<Location> TripLocations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>()
                .HasMany(c => c.TripChats)
                .WithOne(e => e.Trip)
                .HasPrincipalKey(x => x.TripId);

            modelBuilder.Entity<Trip>()
                .HasMany(c => c.TripLocations)
                .WithOne(e => e.Trip)
                .HasPrincipalKey(x => x.TripId);

            modelBuilder.Entity<UserTrip>()
                .HasKey(t => new { t.UserId, t.TripId });
        }
    }
}
