using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Enter your name")]
        public string name { get; set; }

        [Display(Name = "Enter your surname")]
        public string surname { get; set; }

        [Display(Name = "Enter your address")]
        public string address { get; set; }

        [Display(Name = "Enter your phone number")]
        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        //public List<OrderDetail> orderDetail { get; set; }




    }
}
