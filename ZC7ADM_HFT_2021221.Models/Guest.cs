using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZC7ADM_HFT_2021221.Models
{
    class Guest
    {
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        [Key]
        public int GuestId { get; set; }
        [ForeignKey]
        public int OrderId { get; set; }

    }
}
