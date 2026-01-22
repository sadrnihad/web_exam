using Microsoft.EntityFrameworkCore;
using web_exam.Models;

namespace web_exam.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Worker> Workers { get; set; }
    }
}
