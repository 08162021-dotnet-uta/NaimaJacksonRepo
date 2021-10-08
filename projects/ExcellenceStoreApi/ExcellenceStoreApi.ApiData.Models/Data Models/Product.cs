using System;
using System.Collections.Generic;

#nullable disable

namespace ExcellenceStoreApi.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }

        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
