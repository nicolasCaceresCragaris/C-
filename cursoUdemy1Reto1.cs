using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace holaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Programa para multiplicar");
            Console.Write("Ingrese un valor: ");
            string valor = Console.ReadLine();
            

            for(int i = 0; i < 10; i++)
            {
                
                Console.WriteLine("{0}x{1}={2}", valor, i, int.Parse(valor) * i);
            }

        }
    }
}
