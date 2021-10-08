using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellenceStoreApi.Api.DataModels.DataView_Models
{
  public class OrderView
    {
        public Guid ItemizedId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
