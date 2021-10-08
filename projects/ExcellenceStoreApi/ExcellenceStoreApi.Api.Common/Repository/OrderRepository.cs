using ExcellenceStoreApi.Api.Common.Mappers;
using ExcellenceStoreApi.Api.DataModels.DataView_Models;
using ExcellenceStoreApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcellenceStoreApi.Api.Common.Interfaces;

namespace ExcellenceStoreApi.Api.Common.Repository
{
	class OrderRepository: IRepository
	{
		private readonly StoreApplicationDBContext _dbContext;
		public OrderRepository(StoreApplicationDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<List<OrderView>> OrdersAsync(OrderView c, DateTime orderdate)
		{
			List<OrderView> viewmodelorder = new List<OrderView>();

			Order c1 = Mapper.ViewModelOrderToOrder(c);
			// get Orders by date
			if (c1.OrderDate == orderdate)
			{
				List<Order> order = await _dbContext.Orders.FromSqlRaw<Order>($"Select * Order WHERE OrderDate < {orderdate}").ToListAsync();
				// convert to ViewMOdelProduct
				foreach (Order p in order)
				{
					viewmodelorder.Add(Mapper.OrderToViewModelOrder(p));
					viewmodelorder.Sort();
				}
			}
			return viewmodelorder;
		}
	}
}
