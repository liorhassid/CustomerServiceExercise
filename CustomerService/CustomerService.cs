using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    public abstract class CustomerService
    {
        public int LoadIndex { get; set; }

        private ICustomersLine customersLine { get; set; }

        public CustomerService(ICustomersLine newLine)
        { 
            customersLine = newLine;
        }

        public void AddToLine(Customer customer)
        {
            customersLine.AddToLine(customer);
        }

        public Customer RemoveFromLine()
        {
            return customersLine.RemoveFromLine();
        }
    }
}
