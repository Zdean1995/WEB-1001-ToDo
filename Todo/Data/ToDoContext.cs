using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

        public DbSet<ToDo> ToDos { get; set; }

    }
}
