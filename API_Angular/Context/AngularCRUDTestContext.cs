using API_Angular.Mappins;
using API_Angular.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Angular.Context
{
    public class AngularCRUDTestContext : DbContext
    {
        public AngularCRUDTestContext(DbContextOptions<AngularCRUDTestContext> options)
               : base(options)
        {

        }

        public virtual DbSet<Employees> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            new EmployeesMap(modelBuilder.Entity<Employees>());
        }
    }
}
