using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace probandoCosas
{


    internal class Program
    {
        static void Main(string[] args)
        {
            
            for(int i =1; i<101;i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("{0} FizzBuzz", i);
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("{0} Fizz", i);
                }
                else if (i % 5 == 0 ) {
                    Console.WriteLine("{0} Buzz", i);
                }
                else
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
    }
}

