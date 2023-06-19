﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PRN221_Asm02.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Desciption { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
