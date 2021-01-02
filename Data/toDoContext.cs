using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Controllers{
    public class toDoContext:DbContext
    {
        public toDoContext(DbContextOptions<toDoContext> options)
            :base(options)
        {
        }
        public DbSet<Item> toDoItems {get;set;}
    }
}