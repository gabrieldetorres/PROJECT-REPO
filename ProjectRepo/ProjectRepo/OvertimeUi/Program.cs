using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvertimeBl;
using Models;
using OvertimeDL;
namespace OvetimeUi
{
    public class Program
    {

        static TimeSpan time_in = new TimeSpan(9, 0, 0);
        static TimeSpan time_out = new TimeSpan(17, 0, 0);

        static void Main(string[] args)
        {



            OvertimeClass c1 = new OvertimeClass();
            OvetimeClass3 c2 = new OvetimeClass3();



            Console.WriteLine("Time In - Time Out ");

            Console.Write("Enter Employee Id: ");
            c2.Id = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter Employee Name: ");
            c2.Name = Console.ReadLine();

            Console.WriteLine("Enter 24 hour clock:");
            Console.WriteLine();

            Console.Write("Enter Time In: ");
            c2.TimeIn = TimeSpan.Parse(Console.ReadLine());

            Console.Write("Enter Time Out: ");
            c2.Timeout = TimeSpan.Parse(Console.ReadLine());



            Console.WriteLine("\n ============= RECORD ============= ");
            Console.WriteLine("Employee Id: " + c2.Id);
            Console.WriteLine("Employee Name " + c2.Name);
            Console.WriteLine("Time In " + c2.TimeIn);
            Console.WriteLine("Time Out " + c2.Timeout);

            c1.Overtimehours(c2);
            c1.TotalHours(c2);

        }

    }
}



