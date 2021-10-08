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
    class ProductRepository: IRepository
    {
		private readonly StoreApplicationDBContext _dbContext;
		public ProductRepository(StoreApplicationDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<List<ProductView>> ProductsAsync(int prodId)
		{
			List<ProductView> viewmodelproducts = new List<ProductView>();
			// get all the products
			if (prodId == -1)
			{
				List<Product> products = await _dbContext.Products.FromSqlRaw<Product>("Select * FROM Products").ToListAsync();
				// convert to ViewMOdelProduct
				foreach (Product p in products)
				{
					viewmodelproducts.Add(Mapper.ProductToViewModelProduct(p));
				}
				return viewmodelproducts;
			}
			else
			{
				List<Product> products = await _dbContext.Products.FromSqlRaw<Product>($"Select TOP 1 FROM Products WHERE ProductId = {prodId}").ToListAsync();
				// convert to ViewMOdelProduct
				foreach (Product p in products)
				{
					viewmodelproducts.Add(Mapper.ProductToViewModelProduct(p));
					
				}
				return viewmodelproducts;
			}
		}
	}
}
