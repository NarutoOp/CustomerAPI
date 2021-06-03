using CustomerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Services
{
    public class CustomerRepo : IRepo<Customer>
    {
        
        private static List<Customer> customers = new List<Customer>() {
            new Customer { Id = 1, Name="Ramu", Age =  22 },
            new Customer { Id = 2, Name="Samu", Age =  21 }
        };

        

        public bool Add(Customer t)
        {
            try
            {
                customers.Add(t);
                
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public List<Customer> GetAll()
        {
            
            if (customers.Count == 0)
                return null;
            return customers;
        }
    }
}
