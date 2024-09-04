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
            SetCurrentTime(hour, minute);
        }

        public void SetCurrentTime(int hour, int minute)
        {
            CurrentTime = new TimeOnly(hour, minute);
            if (CurrentTime.IsBetween(new TimeOnly(Constants.PrimeTimeStartHour, 0),
                new TimeOnly(Constants.PrimeTimeEndHour, 0)))
                LoadIndex = Constants.PrimeTimeLoadIndex;
            else LoadIndex = Constants.ChillTimeLoadIndex;
        }
    }
}
