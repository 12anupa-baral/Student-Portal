using Microsoft.EntityFrameworkCore;
using Project.Web.Models.Entities;

namespace Project.Web.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        { 

        }
        public DbSet<Student> Students { get; set; }    
    }
}
