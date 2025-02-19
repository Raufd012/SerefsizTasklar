﻿using Microsoft.EntityFrameworkCore;
using SBS.Models;

namespace SBS.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
    }
}
