using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bootstrap bootstrap = new Bootstrap();
            bootstrap.CounterLoadCheck();
            Console.WriteLine("****************************************");
            bootstrap.TimeLoadCheck();
        }
    }
}
