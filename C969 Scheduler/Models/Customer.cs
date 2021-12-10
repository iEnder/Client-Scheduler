using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Scheduler
{
    public class Customer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public int addressId { get; set; }
        public bool active { get; set; }
    }

    public class CustomerCollection
    {
        public Customer customer { get; set; }
        public Address address { get; set; }
        public City city { get; set; }
        public Country country { get; set; }
    }
}
