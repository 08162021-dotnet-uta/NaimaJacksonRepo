using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellenceStoreApi.Api.DataModels.DataView_Models
{
   public class ProductOrderView
    {
        public int ProductOrderId { get; set; }
        public Guid ItemizedId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
    }
}
