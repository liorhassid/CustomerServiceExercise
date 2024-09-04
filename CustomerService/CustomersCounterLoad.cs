using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    public class CustomersCounterLoad : CustomerService
    {
        private int CustomersInLine {  get; set; }

        public CustomersCounterLoad(ICustomersLine newLine) : base(newLine)
        {
            CustomersInLine = newLine.Length();
            LoadIndex = CustomersInLine / Constants.CustomersInLinePerLoadIndex;
        }

        public override void AddToLine(Customer customer)
        {
            base.AddToLine(customer);
            CustomersInLine++;
            LoadIndex = CustomersInLine / Constants.CustomersInLinePerLoadIndex;
            if(LoadIndex > Constants.MaxLoadIndex) LoadIndex = Constants.MaxLoadIndex;
        }

        public override Customer RemoveFromLine()
        {
            Customer customer = base.RemoveFromLine();
            CustomersInLine--;
            LoadIndex = CustomersInLine / Constants.CustomersInLinePerLoadIndex;
            return customer;
        }
    }
}
