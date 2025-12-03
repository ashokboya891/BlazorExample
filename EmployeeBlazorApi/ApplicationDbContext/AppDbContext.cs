
using EmployeeBlazorApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EmployeeBlazorApi.ApplicationDbContext
{
    public class AppDbContext:DbContext
    {
        
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<Employee> Employees => Set<Employee>();
        
    }
}
