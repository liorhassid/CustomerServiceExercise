using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    public class CustomersLineList : ICustomersLine
    {
        private List<Customer> CustomersList;

        public CustomersLineList()
        {
            CustomersList = new List<Customer>();
        }

        public void AddToLine(Customer customer)
        {
            CustomersList.Add(customer);
        }

        public int Length()
        {
            return CustomersList.Count;
        }

        public Customer RemoveFromLine()
        {
            Customer customer = CustomersList[0];
            CustomersList.RemoveAt(0);
            return customer;
        }
    }
}