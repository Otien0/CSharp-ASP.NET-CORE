using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Manager_App.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options) 
        {}

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Countries> Countries { get; set; }
    }
}
