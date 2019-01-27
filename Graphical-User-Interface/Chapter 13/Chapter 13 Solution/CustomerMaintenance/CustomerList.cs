using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    class CustomerList
    {
        private List<Customer> customers;

        public delegate void ChangeHandler(CustomerList customers);
        public event ChangeHandler Changed;

        public CustomerList()
        {
            customers = new List<Customer>();

        }
        public int Count => customers.Count;

        public Customer this[int i]
        {
            get
            {
                return customers[i];
            }
            set
            {
                customers[i] = value;
                Changed(this);
            }
        }
        
        public void Fill() => this.customers = CustomerDB.GetCustomers();
        
        public void Save() => CustomerDB.SaveCustomers(customers);
        
        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
        public void Remove(Customer customer)
        {
            customers.Remove(customer);
        }

    }
}
