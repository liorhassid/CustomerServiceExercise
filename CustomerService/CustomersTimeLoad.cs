using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    public class CustomersTimeLoad : CustomerService
    {
        private TimeOnly CurrentTime {  get; set; }

        public CustomersTimeLoad(ICustomersLine newLine, int hour, int minute) : base(newLine)
        {
            CurrentTime = new TimeOnly(hour, minute);
            if (CurrentTime.IsBetween(new TimeOnly(Constants.PrimeTimeStartHour, 0),
                new TimeOnly(Constants.PrimeTimeEndHour, 0)))
                LoadIndex = Constants.PrimeTimeLoadIndex;
            else LoadIndex = Constants.ChillTimeLoadIndex;
        }
    }
}
