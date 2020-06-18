using Microsoft.EntityFrameworkCore;
using ContosoPets.Api.Models;

namespace ContosoPets.Api.Data
{
    // Creates a Pets-specific implementation of an EF Core DbContext object
    // Provides access to an in-memory database
    public class ContosoPetsContext : DbContext
    {
        public ContosoPetsContext(DbContextOptions<ContosoPetsContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}