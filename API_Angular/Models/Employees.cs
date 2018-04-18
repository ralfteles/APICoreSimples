using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Angular.Models
{
    public class Employees
    {
        public long StudentId { get; set; }
        public string EmpName { get; set; }
        public int? EmpAge { get; set; }
        public string EmpCity { get; set; }
        public string EmpCountry { get; set; }
    }
}
