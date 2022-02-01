using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
     public class ReverseProgram
    {
        public void Rev()
        {
            Console.WriteLine("Enter reverse this number");
            int num = int.Parse(Console.ReadLine());
            int dig = 0, sum = 0;

            while (num > 0)
            {
                dig = num % 10;
                sum = sum * 10 + dig;
                num = num / 10;
            }

            Console.WriteLine("Reverse number is " + sum);
        }
    }
}





