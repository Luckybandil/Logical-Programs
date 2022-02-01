using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public  class FiboSeries
    {
        public void Fibo()
        {
            Console.WriteLine("Enter number of value");
            int num = Convert.ToInt32(Console.ReadLine());

            int a = 1, b = 1, c = 0;
            Console.Write(a + "\t" + b);

            for (int i = 3; i <= num; i++)
            {
                c = a + b;
                System.Console.Write("\t" + c);

                a = b;
                b = c;
            }

            Console.WriteLine("\n");
        }
    }
}
