using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellenceStoreApi.Api.DataModels.DataView_Models
{
	 public class CustomerView
	{
		protected string Fname;
		protected string Lname;

			[StringLength(20, MinimumLength = 1)]
			public string Firstname
			{
				get
				{
					return this.Fname;
				}
				set
				{
					if (value.Length > 50 || value.Length == 0)
					{
						this.Fname = "invalid Name Input";
					}
					else
					{
						this.Fname = value;
					}
				}
			}
			public string Lastname
            {
                get
                {
					return this.Lname;
                }
				set
                {
					if (value.Length > 50 || value.Length == 0)
					{
						this.Lname = "invalid Name Input";
					}
					else
					{
						this.Lname = value;
					}
				}
            }

	

		
		}
	}

