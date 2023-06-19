using System;
using System.Collections.Generic;

#nullable disable

namespace PRN221_Asm02.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SuppilerId { get; set; }
        public int CategoryId { get; set; }
        public int QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public string ProductImage { get; set; }

        public virtual Category Category { get; set; }
        public virtual Supplier Suppiler { get; set; }
    }
}
