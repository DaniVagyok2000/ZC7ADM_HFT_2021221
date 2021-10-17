using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZC7ADM_HFT_2021221.Models
{
    [Table("Employee")]
    public class Employee
    {
        [NotMapped]
        public virtual Restaurant Restaurant { get; set; }
        [Required]
        public string Name { get; set; }
        
        public Food DeliveredFood  { get; set; }
        [Required]
        public int Salary  { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }

        public virtual ICollection<Guest> Guests { get; set; }

        public Employee()
        {
            Guests = new HashSet<Guest>();
        }

    }
}
