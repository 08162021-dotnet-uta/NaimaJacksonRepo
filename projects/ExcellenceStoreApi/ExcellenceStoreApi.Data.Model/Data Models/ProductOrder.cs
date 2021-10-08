using System;
using System.Collections.Generic;

#nullable disable

namespace ExcellenceStoreApi.Models
{
    public partial class ProductOrder
    {
        public ProductOrder()
        {
            Stores = new HashSet<Store>();
        }

        public int ProductOrderId { get; set; }
        public Guid ItemizedId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}
