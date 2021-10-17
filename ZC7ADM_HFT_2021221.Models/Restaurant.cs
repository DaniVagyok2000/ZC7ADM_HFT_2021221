using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZC7ADM_HFT_2021221.Models
{
    [Table("Restaurant")]
    public class Restaurant
    {
        
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public List<Food> Foodlist  { get; set; }
        
        public int Rating { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Restaurant_id{ get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public Restaurant()
        {
            Employees = new HashSet<Employee>();
        }


    }
}
