using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class MonthlyPayement
    {
        public void Monthpay()
        {
           
            Console.Write("Enter Principal Amount");
            double Principal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rate of Interest");
            double Rate = Convert.ToInt32(Console.ReadLine());
            Rate = (Rate / 100) / 12;
            Console.Write("Enter Time period in years");
            int Time = Convert.ToInt32(Console.ReadLine());
            Time = Time * 12;
            double p = (Principal * Rate) / (1 - Math.Pow(1 + Rate, -Time));
            Console.Write("Payment: " + p);
        }

    }
}
