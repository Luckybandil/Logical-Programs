using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class DayOrWeek
    {
        public void Dayweek()
        {
         
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("Month");
                int m = Convert.ToInt32(Console.ReadLine());
                if (m < 1 || m > 12)
                {
                    Console.WriteLine("Months are between 1 and 12");
                    continue;
                }

                Console.WriteLine("Day");
                int d = Convert.ToInt32(Console.ReadLine());
                if (d < 1 || d > 31)
                {
                    Console.WriteLine("Days are between 1 and 31");
                    continue;
                }

                Console.WriteLine("Year");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y < -10000 || y > 10000)
                {
                    Console.WriteLine("Years are between -10000 and 10000");
                    continue;
                }

                int y0 = y - (14 - m) / 12;
                int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
                int m0 = m + 12 * ((14 - m) / 12) - 2;
                int d0 = (d + x + 31 * m0 / 12) % 7;
                bool c = 0 <= d0 && d0 <= 6;
                
                if (c)
                {
                    String b = "Sunday";
                    Console.WriteLine(b);
                }
                else
                {
                    if (c)
                    {
                        String b = "Monday";
                        Console.WriteLine(b);
                    }
                    else
                    {
                        if (c)
                        {
                            String b = "Tuesday";
                            Console.WriteLine(b);
                        }
                        else
                        {
                            if (c)
                            {
                                String b = "Wednesday";
                                Console.WriteLine(b);
                            }
                            else
                            {
                                if (c)
                                {
                                    String b = "Thursday";
                                    Console.WriteLine(b);
                                }
                                else
                                {
                                    if (c)
                                    {
                                        String b = "Friday";
                                        Console.WriteLine(b);
                                    }
                                    else
                                    {
                                        if (c)
                                        {
                                            String b = "Saturday";
                                            Console.WriteLine(b);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                
                 Console.WriteLine("The day of the week");
              
            }
        }
    }

}

