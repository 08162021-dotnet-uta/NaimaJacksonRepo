using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;
using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Storage
{
  public class DemoEF
  {
    private readonly DataAdapter _na = new DataAdapter();

    public List<Customer> GetCustomers()
    {
      return _na.Customers.FromSqlRaw("select * from Customer.Customer").ToList();
    }
    public List<Store> GetStore()
    {
      return _na.Customers.FromSqlRaw("select * from Store.Store").ToList();
    }
    public List<Product> GetProducts()
    {
      return _na.Customers.FromSqlRaw("select * from Store.Product").ToList();
    }
    public List<Order> GetOrders()
    {
      return _na.Customers.FromSqlRaw("select * from Store.Order").ToList();
    }
  }
}