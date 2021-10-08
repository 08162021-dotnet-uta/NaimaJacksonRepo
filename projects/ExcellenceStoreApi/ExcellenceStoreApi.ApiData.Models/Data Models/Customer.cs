using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ExcellenceStoreApi.Models
{
    public partial class Customer
    {
        public Customer()
        {
            ProductOrders = new HashSet<ProductOrder>();
        }

        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Customer First Name is Required")]
        [Display(Name = "Customer First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Customer Last Name is Required")]
        [Display(Name = "Customer Last Name")]
        public string LastName { get; set; }

        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
