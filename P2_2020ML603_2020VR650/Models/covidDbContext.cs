using Microsoft.EntityFrameworkCore;

namespace P2_2020ML603_2020VR650.Models
{
    public class covidDbContext: DbContext
    {

        public covidDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Casos> Casos { get; set; }
    }
}
