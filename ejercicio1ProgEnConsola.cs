using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            //INVERTIR NUMERO DE 2 CIFRAS

            int numero=Convert.ToInt32(Console.ReadLine());
            int valorA;
            int valorB;
            int resultado;

            if(numero>9 && numero < 100)
            {
                valorA = numero / 10;
                valorB=numero%10;

                resultado = (10 * valorB) + valorA;

                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("El numero no es de 2 cifras");
            }
        }   
    }   
}

