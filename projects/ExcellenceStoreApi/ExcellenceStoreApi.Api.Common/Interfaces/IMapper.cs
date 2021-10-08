using ExcellenceStoreApi.Api.DataModels.DataView_Models;
using ExcellenceStoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellenceStoreApi.Api.Common.Interfaces
{
	class IMapper
	{

		CustomerView CustomerToViewModelCustomer(Customer c) { throw new NotImplementedException(); }
		Customer ViewModelCustomerToCustomer(CustomerView c) { throw new NotImplementedException(); }
		Product ViewModelProductToProduct(ProductView c) { throw new NotImplementedException(); }
		ProductView ProductToViewModelProduct(Product c) { throw new NotImplementedException(); }
		Order OrderToViewModelProduct(OrderView c) { throw new NotImplementedException(); }
		OrderView ViewModelOrdertoOrder(Order c) { throw new NotImplementedException(); }
	   public static ProductOrderView ProductOrderToViewModelProductOrder(ProductOrder c) { throw new NotImplementedException(); }
		public static ProductOrder ViewModelProductOrderToProductOrder(ProductOrderView c) { throw new NotImplementedException(); }

		public static Store StoreToViewModelStore(StoreView c) { throw new NotImplementedException(); }
		public static StoreView ViewModelStoreToStore(Store c) { throw new NotImplementedException();}
	}
}

