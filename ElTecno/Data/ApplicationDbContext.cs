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
    }
}
