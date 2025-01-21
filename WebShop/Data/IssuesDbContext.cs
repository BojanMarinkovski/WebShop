using Microsoft.EntityFrameworkCore;
using WebShop.Models;
namespace WebShop.Data
{
    public class IssuesDbContext : DbContext
    {
        public IssuesDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Issue> Issues { get;set;}
    }
}
