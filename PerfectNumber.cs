using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class PerfectNumber
    {
        public void Perfect()
        {
            int num = 28, sum = 0;

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;

                }
            }

            if (sum == num)
            {
                System.Console.WriteLine("perfect number");
            }
        }
    }
}



