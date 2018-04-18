using API_Angular.Mappins;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Angular.Models
{
    //public class AngularCRUDTestContext : DbContext
    //{

    //    public virtual DbSet<Employees> Employees { get; set; }

    //    public AngularCRUDTestContext(DbContextOptions<AngularCRUDTestContext> options)
    //           : base(options)
    //    {

    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {

    //        base.OnModelCreating(modelBuilder);

    //        new EmployeesMap(modelBuilder.Entity<Employees>());

    //        //modelBuilder.Entity<Employees>(entity =>
    //        //{
    //        //    entity.HasKey(e => e.StudentId);

    //        //    entity.Property(e => e.EmpCity)
    //        //        .HasMaxLength(50)
    //        //        .IsUnicode(false);

    //        //    entity.Property(e => e.EmpCountry)
    //        //        .HasMaxLength(50)
    //        //        .IsUnicode(false);

    //        //    entity.Property(e => e.EmpName)
    //        //        .HasMaxLength(50)
    //        //        .IsUnicode(false);
    //        //});
    //    }
    //}
}
