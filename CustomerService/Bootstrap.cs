using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    public class Bootstrap
    {
        public void CounterLoadCheck()
        {
            CustomersCounterLoad service = new CustomersCounterLoad(new CustomersLineList());
            service.AddToLine(new Customer()); service.AddToLine(new Customer()); service.AddToLine(new Customer()); service.AddToLine(new Customer());
            Console.WriteLine(service.LoadIndex);
            service.AddToLine(new Customer());
            Console.WriteLine(service.LoadIndex);
        }

        public void TimeLoadCheck()
        {
            CustomersTimeLoad service = new CustomersTimeLoad(new CustomersLineList(), 7, 30);
            service.AddToLine(new Customer()); service.RemoveFromLine();
            Console.WriteLine(service.LoadIndex);
            service.SetCurrentTime(12, 50);
            Console.WriteLine(service.LoadIndex);
        }
    }
}
