using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Context.DBContext
{
    public class VertoDBContext : IdentityDbContext
    {
        public VertoDBContext(DbContextOptions<VertoDBContext> options) : base(options)
        { }

        public DbSet<Book>? Books { get; set; }
        public DbSet<Student>? Students { get; set; }
    }
}
