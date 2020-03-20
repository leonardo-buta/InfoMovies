using InfoMovies.Domain.Models;
using InfoMovies.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace InfoMovies.Infra.Data.Context
{
    public class InfoMoviesContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public InfoMoviesContext(DbContextOptions<InfoMoviesContext> options) : base(options)
        {
            
        }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MovieMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
