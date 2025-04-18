﻿using Microsoft.EntityFrameworkCore;

namespace RazorCrudDemo_FACIT.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }

}
