using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI;database=coremovie; integrated security=true");
        }


        public DbSet<Movie> movies { get; set; }
        
    }
}