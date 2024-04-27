using Microsoft.EntityFrameworkCore;

namespace CinemaSIte.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<UserClass> Users { get; set; }
        public DbSet<FilmModel> Films { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=CinemaDataBase;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
