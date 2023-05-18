using System;
using System.Text;

namespace Lesser_Angle
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success = false;

            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Input hours (1 - 12) and minutes (0 - 59), respectively:\n");

            string[] input = Console.ReadLine().Split(' ');

            //char key = Console.ReadKey().KeyChar; char key2 = Console.ReadKey().KeyChar;

            do
            {
                try
                {
                    decimal hour = decimal.Parse(input[0].ToString()); decimal minute = decimal.Parse(input[1].ToString());

                    if (hour < 1 || hour > 12 || minute < 0 || minute > 59)
                    {
                        Console.Write("Invalid input. Please input the numbers again.\nInput hours(1 - 12) and minutes(0 - 59), respectively:\n");
                    }

                    else
                    {
                        success = true;

                        get_lesserangle(hour, minute);
                    }
                }

                catch (Exception error)
                {
                    Console.Write(error);

                    Console.Write("Invalid input. Please input the numbers again.\nInput hours(1 - 12) and minutes(0 - 59), respectively:\n");
                }
            }

            while (success == false);

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();


        }
        
        static void get_lesserangle(decimal hour, decimal minute)
        {
            decimal hour_angle = 0, minute_angle = 0, lesser_angle = 0;

            hour_angle = Math.Ceiling((hour + (minute / 60)) * 30);
            minute_angle = 6 * minute;

            lesser_angle = Math.Abs(hour_angle - minute_angle);

            Console.WriteLine("\nThe hour is {0} and the minute is {1}.", hour, minute);

            Console.WriteLine("\nThe hour angle is {0} and the minute angle is {1}.", hour_angle, minute_angle);

            Console.WriteLine("\nThe lesser angle is {0} degrees.", lesser_angle);
        }

            
    }
}
