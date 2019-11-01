using Microsoft.EntityFrameworkCore;

namespace Parks.Models
{
    public class ParksContext : DbContext
    {
        public ParksContext(DbContextOptions<ParksContext> options)
        : base(options)
        {

        }

        public DbSet<Park> Parks {get; set;}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                .HasData(

                    new Park {ParkId = 1, Name= "Carlsbad Caverns", Land = "National", State="NM"},
                    new Park {ParkId = 2, Name= "Chaco  Canyon", Land = "National", State="NM"},
                    new Park {ParkId = 3, Name= "Manhattan Project", Land = "National", State="NM"},
                    new Park {ParkId = 4, Name= "Pecos", Land = "National", State="NM"},
                    new Park {ParkId = 5, Name= "Black Canyon", Land = "National", State="CO"},
                    new Park {ParkId = 6, Name= "Sand Dunes", Land = "National", State="CO"},
                    new Park {ParkId = 7, Name= "Mesa Verde", Land = "National", State="CO"},
                    new Park {ParkId = 8, Name= "Rocky Mountain", Land = "National", State="CO"},
                    new Park {ParkId = 9, Name= "Elephant Butte", Land = "State", State="NM"},
                    new Park {ParkId = 10, Name= "Santa Rosa", Land = "State", State="NM"},
                    new Park {ParkId = 11, Name= "Spinney", Land = "State", State="CO"},
                    new Park {ParkId = 12, Name= "Castlewood", Land = "State", State="CO"}

            );
        }
    }
}