using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Start Integer: ");
            int start = Int16.Parse(Console.ReadLine());
            Console.Write("Please Enter Start Integer: ");
            int end = Int16.Parse(Console.ReadLine());

            if(start >= end)
            {
                
                for (int cnt = start; cnt >= end; cnt--)
                {
                    if (cnt % 15 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                        continue;
                    }

                    if (cnt % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                        continue;
                    }

                    if (cnt % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                        continue;
                    }

                    Console.WriteLine("{0}", cnt);
                }
            }
            else
            {
                for (int cnt = start; cnt <= end; cnt++)
                {
                    if (cnt % 15 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                        continue;
                    }

                    if (cnt % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                        continue;
                    }

                    if (cnt % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                        continue;
                    }

                    Console.WriteLine("{0}", cnt);
                }
            }

            Console.ReadKey();
        }
    }
}
