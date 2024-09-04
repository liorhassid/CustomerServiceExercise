using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    public interface ICustomersLine
    {
        void AddToLine(Customer customer);

        Customer RemoveFromLine();
    }
}
