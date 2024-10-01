using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PTPMQL.Models;
using DemoMvc.Models;
using PTPMQL;

namespace DemoMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PTPMQL.Models.Employee> Employee { get; set; } = default!;
        public DbSet<DemoMvc.Models.Person> Person { get; set; } = default!;
        public DbSet<PTPMQL.Employe> Employe { get; set; } = default!;
       
    }
}
