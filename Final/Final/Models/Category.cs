using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Category
    {
        //[Display(Name = "Id")]
        public int id { set; get; }

        //[Display(Name = "Name")]
        public string cat_name { set; get; }

        //[Display(Name = "Characteristics")]
        public string charact { set; get; }

        public List<Comp> comps { set; get; }
    }
}
