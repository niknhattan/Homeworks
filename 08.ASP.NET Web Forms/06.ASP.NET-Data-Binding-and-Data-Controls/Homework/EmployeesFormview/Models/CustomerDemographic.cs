using System;
using System.Collections.Generic;

namespace EmployeesFormview.Models
{
    public partial class CustomerDemographic
    {
        public CustomerDemographic()
        {
            this.Customers = new List<Customer>();
        }

        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
