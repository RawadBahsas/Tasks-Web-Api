using Microsoft.EntityFrameworkCore;
using TasksWebApi.Model;

namespace TasksWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<MyTask> MyTasks { get; set; }
    }
}
