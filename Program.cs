using System.Threading;
using ClassLibrary1;
using Overtime;


namespace PROJECT_REPO
{
    internal class Program
    {
        static TimeSpan time_in = new TimeSpan(9, 0, 0);
        static TimeSpan time_out = new TimeSpan(17, 0, 0);

        static void Main(string[] args)
        {

            timIn_timeOut emp = new timIn_timeOut();
            Overtime1 ot = new Overtime1();

            Console.WriteLine("Time In / Time Out ");

            Console.Write("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter 24 hour clock: ");
            Console.WriteLine();

            Console.Write("Enter Time In: ");
            TimeSpan timeIn = TimeSpan.Parse(Console.ReadLine());

            Console.Write("Enter Time Out: ");
            TimeSpan timeOut = TimeSpan.Parse(Console.ReadLine());

            
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Time In: " + timeIn);
            Console.WriteLine("Time Out: " + timeOut);

            ot.Overtimehours(emp);
            ot.TotalHours(emp);

        }
    }
}