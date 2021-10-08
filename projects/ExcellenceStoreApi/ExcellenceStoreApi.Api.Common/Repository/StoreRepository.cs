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
	class StoreRepository:IRepository
	{
		private readonly StoreApplicationDBContext _dbContext;
		public StoreRepository(StoreApplicationDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<List<StoreView>> StoreAsync(int productorder)
		{
			List<StoreView> viewmodelstore = new List<StoreView>();
			// get all the products
			if (productorder == -1)
			{
				List<Store> store = await _dbContext.Stores.FromSqlRaw<Store>("Select * FROM Store").ToListAsync();
				// convert to ViewMOdelProduct
				foreach (Store p in store)
				{
					viewmodelstore.Add(Mapper.ViewModelStoreToStore(p));
				}
				return viewmodelstore;
			}
			else
			{
				List<Store> store = await _dbContext.Stores.FromSqlRaw<Store>($"Select TOP 1 FROM Store WHERE ProductOrderId = {productorder}").ToListAsync();
				// convert to ViewMOdelProduct
				foreach (Store p in store)
				{
					viewmodelstore.Add(Mapper.ViewModelStoreToStore(p));

				}
				return viewmodelstore;
			}


		}
	}
}
