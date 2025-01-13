using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    
        public DbSet<ToDoApp.Models.Task> Tasks { get; set; }
    }
}
