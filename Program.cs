using System.Threading;

namespace PROJECT_REPO
{
    internal class Program
    {

        static TimeSpan time_in = new TimeSpan(9, 0, 0);
        static TimeSpan time_out = new TimeSpan(17, 0, 0);
        static void Main(string[] args)
        {
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




            Console.WriteLine("\n===== RECORD =====");
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Time In: " + timeIn);
            Console.WriteLine("Time Out: " + timeOut);

            if (timeIn > time_in)
            {
                Console.WriteLine("Status: Late");
            }
            else if (timeIn < time_in)
            {
                Console.WriteLine("Early Bird");
            }
            else
            {
                Console.WriteLine("Status: On Time");
            }


            if (timeOut > time_out)
            {
                Console.WriteLine("Overtime");
            }
            else
            {
                Console.WriteLine("No Overtime");
            }

            Hours(timeIn, timeOut);
        }

        static void Hours(TimeSpan timein, TimeSpan timeout)
        {
            TimeSpan totalHours = timeout - timein;
            Console.WriteLine("Total Working Hours: " + totalHours);
        }
    }
}