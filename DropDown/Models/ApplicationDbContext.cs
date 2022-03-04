using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DropDown.Models;
namespace DropDown.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) { }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> states { get; set; }
        public DbSet<City> cities { get; set; }
    }
}
