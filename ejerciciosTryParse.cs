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

            string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            string finalWord="";
            decimal container;
            decimal totalValue=0;

            foreach(string value in values)
            {
                if (decimal.TryParse(value, out container))
                {
                    totalValue += container;
                }
                else
                {
                    finalWord = finalWord + value;
                }
            }
            Console.WriteLine(finalWord);
            Console.WriteLine(totalValue);


        }


    }   
}
