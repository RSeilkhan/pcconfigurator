using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public int price { get; set; }
        public string ShopCartId { get; set; }
        public Comp comp { get; set; }



    }
}
