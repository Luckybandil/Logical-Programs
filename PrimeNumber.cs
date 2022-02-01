using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class PrimeNumber
    {
        public void Prime()
        {
            System.Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Prime number");
            }
            
        }
    }
}




