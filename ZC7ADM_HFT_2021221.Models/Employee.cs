using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZC7ADM_HFT_2021221.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Food  { get; set; }
        public int Salary  { get; set; }
        [Key]
        public int EmployeeId { get; set; }
        [ForeignKey]
        public int GuestId { get; set; }

    }
}
