using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZC7ADM_HFT_2021221.Models
{
    [Table("Guest")]
    public class Guest
    {
        [Required]
        public string Name { get; set; }
        [NotMapped]
        public virtual Employee Employee { get; set; }
        [EmailAddress]
        public string Email { get; set; }        
        public string Number { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int GuestId { get; set; }
        [ForeignKey(nameof(Employee))]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public Food DeliveredFood { get; set; }

    }
}
