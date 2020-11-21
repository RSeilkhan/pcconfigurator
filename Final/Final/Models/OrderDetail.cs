using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orID { get; set; }
        public int CompID { get; set; }
        public int price { get; set; }
        public virtual Comp comp { get; set; }
        public virtual Order order { get; set; }



    }
}
