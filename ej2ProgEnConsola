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
            int valorC;
            int aux;
            int resultado;

            if(numero>99 && numero < 1000)
            {
                valorA = numero / 100;
                aux = numero % 100;
                valorB = aux / 10;
                valorC=aux%10;

                resultado = (100 * valorC) + (10*valorB)+(valorA);

                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("El numero no es de 2 cifras");
            }

        } 
    }   
}


