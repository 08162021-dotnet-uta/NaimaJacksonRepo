using ExcellenceStoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExcellenceStoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly StoreApplicationDBContext _context = new StoreApplicationDBContext();
        [HttpGet]
        public async Task<IActionResult> Insert(Customer c)
        {
            if(c == null )
            {
               await _context.Customers.AddAsync(c);
            }
    
            return View();
        }

    }
}
