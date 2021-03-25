using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ben Shaw

namespace Day_time_taxi_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengers = 0;
            int distance = 0;
            double cost = 0;

            Console.WriteLine("Enter a negative number to exit the program while inputing the amount of passengers/distance");
            Console.ReadKey();
            Console.Clear();
            while (true)
            {
                passengers = 0;
                distance = 0;
                cost = 0;
                try
                {
                    Console.Write("Enter amount of passengers: ");
                    passengers = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.Write("Enter amount of distance travelled (kilometres): ");
                    distance = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (passengers < 0|| distance < 0)
                    {
                        Console.WriteLine("The program will now exit");
                        Console.ReadKey();
                        return;
                    }
                    else if (passengers <5)
                    {
                        cost = 3 + (distance - 1) *2;
                        Roundup(cost, 2);
                    }
                    else
                    {
                        cost = (3 + (distance - 1) * 2) *1.5;
                        Roundup(cost, 2);
                    }

                    Console.WriteLine("£"+cost);
                    Console.ReadKey();
                }

                catch
                {
                    Console.WriteLine("An error has occured somewhere the program will restart");
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
        public static double Roundup(double input, int places)
        {
            double multiplier = Math.Pow(10, Convert.ToDouble(places));
            return Math.Ceiling(input * multiplier) / multiplier;
        }

    }
}
