using ElTecno.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ElTecno.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Component> Components { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Component>().HasData(
                new Component
                {
                    Id = 1,
                    Name = "Api Clima",
                    Type = "clima",
                    ApiUrl = "https://api.open-meteo.com/v1/forecast?latitude=9.93&longitude=-84.08&current=temperature_2m",
                    RefreshInterval = 30,
                    IsActive = true,
                    Description = "Api del Clima",
                    Size = "medium",         
                    Position = "medium", 
                    IsFavorite = false,
                    ApiKey = "****"
                }
            );
        }
    }
}
