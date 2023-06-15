using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Problem_D6
{
    public class Celsius_to_Fahrenheit
    {
        public void Findcelsius(double celsius)
        {
            double fahrenheit;
            
            if (celsius < -273.15)
            {
                Console.WriteLine("Temperature below absolute zero!");
            }

            fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine($"{fahrenheit}F");
        }
    }
}
