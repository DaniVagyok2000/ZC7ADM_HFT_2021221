using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZC7ADM_HFT_2021221.Models
{
     public class Restaurant
    {
        public string Chef { get; set; }
        public List<Food> Foodlist  { get; set; }
        public int Rating { get; set; }


    }
}
