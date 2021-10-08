using ExcellenceStoreApi.Api.Common.Interfaces;
using ExcellenceStoreApi.Api.Common.Mappers;
using ExcellenceStoreApi.Api.DataModels.DataView_Models;
using ExcellenceStoreApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellenceStoreApi.Api.Common.Repository
{
	class ProductOrderRepository: IRepository
	{
		private readonly StoreApplicationDBContext _dbContext;
		public ProductOrderRepository(StoreApplicationDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<List<ProductOrderView>> ProductsAsync(ProductOrderView c, int custid)
		{
			List<ProductOrderView> viewmodelproductorder = new List<ProductOrderView>();

			ProductOrder c1 = Mapper.ViewModelProductOrderToProductOrder(c);
			// get all the products
			if (c1.CustomerId == custid)
			{
				List<ProductOrder> productorder = await _dbContext.ProductOrders.FromSqlRaw<ProductOrder>($"Select ProductId FROM ProductOrder WHERE CustomerId = {custid}").ToListAsync();
				// convert to ViewMOdelProduct
				foreach (ProductOrder p in productorder)
				{
					viewmodelproductorder.Add(Mapper.ProductOrderToViewModelProductOrder(p));
				}
			}
			return viewmodelproductorder;

		}
	}
}
