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

                    new Park {ParkId = 1, Name= "", Land = "", State=""},
                    new Park {ParkId = 1, Name= "", Land = "", State=""},
                    new Park {ParkId = 1, Name= "", Land = "", State=""},
                    new Park {ParkId = 1, Name= "", Land = "", State=""},
                    new Park {ParkId = 1, Name= "", Land = "", State=""},
                    new Park {ParkId = 1, Name= "", Land = "", State=""},
                    new Park {ParkId = 1, Name= "", Land = "", State=""},
                    new Park {ParkId = 1, Name= "", Land = "", State=""},
                    new Park {ParkId = 1, Name= "", Land = "", State=""},
                    new Park {ParkId = 1, Name= "", Land = "", State=""}
            );
        }
    }
}