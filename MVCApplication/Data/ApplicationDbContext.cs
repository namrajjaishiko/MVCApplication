using Microsoft.EntityFrameworkCore;
using MVCApplication.Models;
using WebApplication1.Models;

namespace MVCApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Persons> person { get; set; }
    }
}
