using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcellenceStoreApi.Api.Common.Interfaces;
using ExcellenceStoreApi.Api.Common.Mappers;
using ExcellenceStoreApi.Api.DataModels.DataView_Models;
using ExcellenceStoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExcellenceStoreApi.Api.Common.Repository
{
    class CustomerRepository: IRepository
    {
        private readonly StoreApplicationDBContext _dbContext;
        public CustomerRepository(StoreApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
		/// <summary>
		/// This method will take a ViewModelVustomer object and return the ViewModelCustomer
		/// if found in the Db.
		/// Null if not found.
		/// </summary>
		/// <returns></returns>
		public async Task<CustomerView> LoginCustomerAsync(CustomerView vmc)
		{
			Customer c1 = Mapper.ViewModelCustomerToCustomer(vmc);

			Customer c2 = await _dbContext.Customers.FromSqlRaw<Customer>("SELECT * FROM Customers WHERE FirstName = {0} and LastName = {1}", c1.FirstName, c1.LastName).FirstOrDefaultAsync();// default is NULL

			if (c2 == null) return null;

			CustomerView c3 = Mapper.CustomerToViewModelCustomer(c2);
			return c3;
		}

		public async Task<CustomerView> RegisterCustomerAsync(CustomerView vmc)
		{
			Customer c1 = Mapper.ViewModelCustomerToCustomer(vmc);

			int c2 = await _dbContext.Database.ExecuteSqlRawAsync("INSERT INTO Customers (FirstName, LastName) VALUES ({0},{1})", c1.FirstName, c1.LastName);// default is NULL

			if (c2 != 1) return null;


			return await LoginCustomerAsync(vmc);
		}

		/// <summary>
		/// This method getss a list of all the products or a single product given an arg.
		/// </summary>
		/// <returns></returns>

		public async Task<List<CustomerView>> CustomerListAsync()
		{
			List<Customer> customers = await _dbContext.Customers.FromSqlRaw<Customer>("Select * FROM Customers").ToListAsync();
			List<CustomerView> vmc = new List<CustomerView>();
			foreach (Customer c in customers)
			{
				vmc.Add(Mapper.CustomerToViewModelCustomer(c));
			}
			return vmc;
		}


	}
}
