﻿using InfoMovies.Domain.Models;
using InfoMovies.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace InfoMovies.Infra.Data.Context
{
    public class InfoMoviesContext : DbContext
    {
        private readonly IHostingEnvironment _env;

        public DbSet<Movie> Movies { get; set; }

        public InfoMoviesContext(IHostingEnvironment env)
        {
            _env = env;
        }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MovieMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var config = new ConfigurationBuilder()
            //    .SetBasePath
        }

    }
}
