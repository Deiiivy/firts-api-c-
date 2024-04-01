using Microsoft.EntityFrameworkCore;
using FIRTS_API_CRUD.Models;

namespace FIRTS_API_CRUD.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
    }

}
