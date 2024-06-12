﻿using BlazorSqlitePOC.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorSqlitePOC.Data;

public class AppDbContext : DbContext
{
    public AppDbContext() { }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
}