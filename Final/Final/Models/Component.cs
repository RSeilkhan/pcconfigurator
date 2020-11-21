using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Component
    {
        [Display(Name = "Id")]
        public int id { set; get; }

        [Display(Name = "Name")]
        public string comp_name { set; get; }

        [Display(Name = "Description")]
        public string desc { set; get; }

        [Display(Name = "Price")]
        public int price { set; get; }

        [Display(Name = "EffScore")]
        public int EffScore { set; get; }

        [Display(Name = "Image")]
        public string img { set; get; }

        [Display(Name = "PCAssemble")]
        public bool inBasket { set; get; }

        [Display(Name = "Category ")]
        public int categoryID { set; get; }

        public virtual Category category { set; get; }
    }
}
