using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Calendar
    {
        static void Main()
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            bool isLeapYear = DateTime.IsLeapYear(year);
            for (int month = 1; month <= 12; month++)
            {
                DateTime date = new DateTime(year, month, 1);
                Console.WriteLine(date.ToString("MMMM"));
                Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
                int daysInMonth = DateTime.DaysInMonth(year, month);
                int dayOfWeek = (int)date.DayOfWeek;
                for (int i = 0; i < dayOfWeek; i++)
                {
                    Console.Write("    ");
                }
                for (int day = 1; day <= daysInMonth; day++)
                {
                    Console.Write("{0, 3}", day);
                    if ((dayOfWeek + day) % 7 == 0)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

}
