using System;
using System.Collections.Generic;

#nullable disable

namespace ExcellenceStoreApi.Models
{
    public partial class Store
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public int ProductOrderId { get; set; }

        public virtual ProductOrder ProductOrder { get; set; }
    }
}
