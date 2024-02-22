using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you want to convert Celsius to Fahrenheit, type CEL, otherwise type FAHR: ");
            string temperature = Console.ReadLine();

            if (temperature.ToUpper() == "CEL")
            {
                Console.WriteLine("Enter the temperature in Celsius: ");
                float x = float.Parse(Console.ReadLine());
                double temper = x * 33.8;
                Console.WriteLine("The " + x + " Celsius equals " + temper + " Fahrenheits.");
            }
            else if (temperature.ToUpper() == "FAHR")
            {
                Console.WriteLine("Enter the temperature in Fahrenheits: ");
                float x = float.Parse(Console.ReadLine());
                double temper = (x-32) / 1.8;
                Console.WriteLine("The " + x + " Fahrenheits equals " + temper + " Celsius.");
            }
            else
            {
                Console.WriteLine("Check if the input info is correct.");
            }
            Console.ReadKey();
        }
        
    }
}
