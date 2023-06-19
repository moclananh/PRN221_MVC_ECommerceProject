using System;
using System.Collections.Generic;

#nullable disable

namespace PRN221_Asm02.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int Freight { get; set; }
        public string ShipAddress { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
