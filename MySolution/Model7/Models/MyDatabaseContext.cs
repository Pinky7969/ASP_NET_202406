﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Model7.Models;

public partial class MyDatabaseContext : DbContext
{
    public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TodoItem> TodoItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
        modelBuilder.Entity<TodoItem>().HasData(
            new TodoItem { Id = 1, Name = "Learn C#", IsComplete = false },
            new TodoItem { Id = 2, Name = "Learn EF Core", IsComplete = false },
            new TodoItem { Id = 3, Name = "Learn ASP.NET Core", IsComplete = false },
            new TodoItem { Id = 4, Name = "Learn EF Core Power Tools", IsComplete = false }
        );
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}