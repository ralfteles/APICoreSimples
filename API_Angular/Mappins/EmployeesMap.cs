using API_Angular.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Angular.Mappins
{
    public class EmployeesMap
    {
        public EmployeesMap(EntityTypeBuilder<Employees> builder)
        {
            builder.HasKey(e => e.StudentId);

            builder.Property(e => e.EmpCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

            builder.Property(e => e.EmpCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

            builder.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
        }
    }
}
