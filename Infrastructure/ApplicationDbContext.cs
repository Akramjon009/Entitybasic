using Entitybasic.Model;
using Microsoft.EntityFrameworkCore;

namespace Entitybasic.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Programmer> Programmers { get; set; }
    }
}
