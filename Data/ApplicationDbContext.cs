using HotelMicroservicio.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelMicroservicio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
                .HasKey(r => r.room_id);
        }
    }
}
