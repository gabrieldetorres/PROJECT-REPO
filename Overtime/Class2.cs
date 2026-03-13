using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeIn_TimeOut;

namespace Overtime
{
    public class Class2
    {
        TimeSpan time_in = new TimeSpan(9, 0, 0);
        TimeSpan time_out = new TimeSpan(17, 0, 0);

        public void Overtimehours(Class1 emp)
        {
            if (emp.TimeIn > time_in)
            {
                Console.WriteLine("Status: Late");
            }
            else if (emp.TimeIn < time_in)
            {
                Console.WriteLine("Early Bird");
            }
            else
            {
                Console.WriteLine("Status: On Time ");
            }

            if (emp.Timeout > time_out)
            {
                Console.WriteLine("Overtime");
            }
            else
            {
                Console.WriteLine("No Overtime");
            }
        }

        public void TotalHours(Class1 emp)
        {
            TimeSpan hours = emp.Timeout - emp.TimeIn;
            Console.WriteLine("Total Working Hours: " + hours);
        }
    }
}