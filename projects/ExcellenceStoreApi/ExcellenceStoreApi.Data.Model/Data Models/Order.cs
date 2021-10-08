using System;
using System.Collections.Generic;

#nullable disable

namespace ExcellenceStoreApi.Models
{
    public partial class Order
    {
        public Guid ItemizedId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
