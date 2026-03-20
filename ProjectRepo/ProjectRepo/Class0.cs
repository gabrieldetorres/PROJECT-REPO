using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overtime;
using TimeIn_TimeOut;

namespace ProjectRepo
{
    public class Class0
    {

        static TimeSpan time_in = new TimeSpan(9, 0, 0);
        static TimeSpan time_out = new TimeSpan(17, 0, 0);

        static void Main(string[] args)
        {



            Class1 c1 = new Class1();
            Class2 c2 = new Class2();



            Console.WriteLine("Time In - Time Out ");

            Console.Write("Enter Employee Id: ");
            c1.Id = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter Employee Name: ");
            c1.Name = Console.ReadLine();

            Console.WriteLine("Enter 24 hour clock:");
            Console.WriteLine();

            Console.Write("Enter Time In: ");
            c1.TimeIn = TimeSpan.Parse(Console.ReadLine());

            Console.Write("Enter Time Out: ");
            c1.Timeout = TimeSpan.Parse(Console.ReadLine());



            Console.WriteLine("\n ============= RECORD ============= ");
            Console.WriteLine("Employee Id: " + c1.Id);
            Console.WriteLine("Employee Name " + c1.Name);
            Console.WriteLine("Time In " + c1.TimeIn);
            Console.WriteLine("Time Out " + c1.Timeout);

            c2.Overtimehours(c1);
            c2.TotalHours(c1);

        }

    }
}



