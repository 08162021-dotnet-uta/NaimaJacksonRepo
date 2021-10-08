using System;
using System.Collections.Generic;

#nullable disable

namespace ExcellenceStoreApi.Models
{
    public partial class Customer
    {
        public Customer()
        {
            ProductOrders = new HashSet<ProductOrder>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
