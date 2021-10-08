using ExcellenceStoreApi.Api.Common.Interfaces;
using ExcellenceStoreApi.Api.DataModels.DataView_Models;
using ExcellenceStoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExcellenceStoreApi.Api.Common.Mappers
{
	class Mapper
	{
		public static CustomerView CustomerToViewModelCustomer(Customer c)
		{
			CustomerView c1 = new();
			c1.Firstname = c.FirstName;
			c1.Lastname = c.LastName;
			return c1;


		}

		/// <summary>
		/// This method takes a ViewModelCustomer and returns the mapping to a Customer
		/// </summary>
		/// <param name="c"></param>
		/// <returns></returns>
		public static Customer ViewModelCustomerToCustomer(CustomerView c)
		{


			Customer c1 = new();

			c1.FirstName = c.Firstname;
			c1.LastName = c.Lastname;
			return c1;
		}

		/// <summary>
		/// This method takes a ViewModelProduct and returns the mapping to a Product
		/// </summary>
		/// <param name="c"></param>
		/// <returns></returns>
		public static Product ViewModelProductToProduct(ProductView c)
		{
			Product c1 = new();
			c1.ProductId = c.ProductId;
			c1.ProductName = c.ProductName;
			c1.ProductPrice = c.ProductPrice;
			return c1;
		}

		/// <summary>
		/// This method takes a Product and returns the mapping to a ViewModelProduct
		/// </summary>
		/// <param name="c"></param>
		/// <returns></returns>
		public static ProductView ProductToViewModelProduct(Product c)
		{
			ProductView c1 = new ProductView();
			c1.ProductId = c.ProductId;
			c1.ProductName = c.ProductName;
			c1.ProductPrice = c.ProductPrice;
			return c1;
		}
		/// <summary>
		/// This method takes a ViewModelProduct and returns the mapping to a Product
		/// </summary>
		/// <param name="c"></param>
		/// <returns></returns>
		public static Order ViewModelOrderToOrder(OrderView c)
		{
			Order c1 = new();
			c1.ItemizedId = c.ItemizedId;
			c1.OrderDate = c.OrderDate;
			return c1;


		}

		/// <summary>
		/// This method takes a Product and returns the mapping to a ViewModelProduct
		/// </summary>
		/// <param name="c"></param>
		/// <returns></returns>
		public static OrderView OrderToViewModelOrder(Order c)
		{
			OrderView c1 = new OrderView();
			c1.ItemizedId = c.ItemizedId;
			c1.OrderDate = c.OrderDate;
			return c1;
		}       /// <summary>
				/// This method takes a ViewModelProduct and returns the mapping to a Product
				/// </summary>
				/// <param name="c"></param>
				/// <returns></returns>
		public static Store ViewModelStoreToStore(StoreView c)
		{
			Store c1 = new();
			c1.StoreId = c.StoreId;
			c1.StoreName = c.StoreName;
			c1.ProductOrderId = c.ProductOrderId;
			return c1;

			
		/// <summary>
		/// This method takes a Product and returns the mapping to a ViewModelProduct
		/// </summary>
		/// <param name="c"></param>
		/// <returns></returns>
			static StoreView StoreToViewModelStore(Store c)
			{
				StoreView c1 = new StoreView();
				c1.StoreId = c.StoreId;
				c1.StoreName = c.StoreName;
				c1.ProductOrderId = c.ProductOrderId;
				return c1;
			}       /// <summary>
					/// This method takes a ViewModelProduct and returns the mapping to a Product
					/// </summary>
					/// <param name="c"></param>
					/// <returns></returns>
			static ProductOrder ViewModelProductToProduct(ProductOrderView c)
			{
				ProductOrder c1 = new ProductOrder();
				c1.ProductOrderId = c.ProductOrderId;
				c1.ItemizedId = c.ItemizedId;
				c1.ProductId = c.ProductId;
				c1.CustomerId = c.CustomerId;
				return c1;
			}

			/// <summary>
			/// This method takes a Product and returns the mapping to a ViewModelProduct
			/// </summary>
			/// <param name="c"></param>
			/// <returns></returns>
			 static ProductOrderView ProductOrderToViewModelProductOrder(ProductOrder c)
			{
				ProductOrderView c1 = new ProductOrderView();
				c1.ProductOrderId = c.ProductOrderId;
				c1.ItemizedId = c.ItemizedId;
				c1.ProductId = c.ProductId;
				c1.CustomerId = c.CustomerId;
				return c1;
			}
		}
	}
}

	

   

