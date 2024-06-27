using Microsoft.EntityFrameworkCore;
using Model6.Models;

namespace Model6.Data;

public class TodoContext(DbContextOptions<TodoContext> options): DbContext(options)
{
    public DbSet<TodoItem> TodoItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TodoItem>().HasData(
            new TodoItem { Id = 1, Name = "Learn ASP.NET Core", IsComplete = false },
            new TodoItem { Id = 2, Name = "Build apps", IsComplete = false },
            new TodoItem { Id = 3, Name = "Deploy apps", IsComplete = true },
            new TodoItem { Id = 4, Name = "Learn Blazor", IsComplete = false }
        );
    }
}
