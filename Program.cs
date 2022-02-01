using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number for select Option: \n 1. FiboSeries \n 2.PerfectNumber  \n 3.PrimeNumber  \n 4. ReverseProgram \n 5. VendingMach \n6. DayOrWeek\n 7. MonthlyPayement\n 8. TemperatureConversion\n 9. Exit.\n ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                FiboSeries fiboSeries = new FiboSeries();
                fiboSeries.Fibo();
                break;

                case 2:
                PerfectNumber perfectNumber = new PerfectNumber();
                perfectNumber.Perfect();
                break;

                case 3:
                PrimeNumber primeNumber = new PrimeNumber();
                primeNumber.Prime();
                break;

                case 4:
                ReverseProgram reverseProgram = new ReverseProgram();
                reverseProgram.Rev();
                break;
               
                case 5:
                VendingMach vendingMach = new VendingMach();
                vendingMach.Vending();
                break;

                case 6:
                DayOrWeek dayOrWeek = new DayOrWeek();  
                dayOrWeek.Dayweek();
                break;

                case 7:
                MonthlyPayement monthlyPayement = new MonthlyPayement();
                monthlyPayement.Monthpay();
                break;
                case 8:
                TemperatureConversion temperatureConversion = new TemperatureConversion();
                temperatureConversion.TempConv();
                break;

                case 9:
                break;
                default:
                System.Console.WriteLine("select correct number");
                break;

            }


        }

    }
}