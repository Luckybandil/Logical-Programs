using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class TemperatureConversion
    {
        public void TempConv()
        {
            double fahrenheit;

            double celsius = 36;
            Console.WriteLine("Celsius" + celsius);

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit" + fahrenheit);

            Console.WriteLine("Enter Fahrenheit Temperature");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine());
            
            double Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The converted Celsius temperature is" + Celsius);

            Console.ReadLine();
        }
    }
}
