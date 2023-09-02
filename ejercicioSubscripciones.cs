using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace subscripciones
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            if (daysUntilExpiration<= 10 && daysUntilExpiration>5)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }
            if(daysUntilExpiration<= 5 && daysUntilExpiration>1) {
                discountPercentage = 10;
                Console.WriteLine("Your subscription expires in {0} days.\r" +
                    "\nRenew now and save {1}%!",daysUntilExpiration,discountPercentage);
            
            }
            if(daysUntilExpiration==1) {
                discountPercentage = 20;
                Console.WriteLine("Your subscription expires within a day." +
                    "Renew now and save {0} % !",discountPercentage);
            }
            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            {
                
            }


        }
   


     }
}
