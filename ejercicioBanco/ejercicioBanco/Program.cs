using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente clienteUno= new Cliente("Roberto");
            Cliente clienteDos= new Cliente("Alberto");
            Cliente clienteTres= new Cliente("Eduardo"); 

            Banco banco= new Banco(clienteUno, clienteDos,clienteTres);

            decimal monto;
            
            Console.WriteLine("Ingrese 0 para ingresar dinero a su cuenta.");
            Console.WriteLine("Ingrese 1 para retirar dinero de su cuenta.");
            Console.WriteLine("Ingrese 2 para ver el dinero de su cuenta.");

            int opcion = Convert.ToInt32(Console.ReadLine());

            while (opcion >= 0)
            {
                switch (opcion)
                {
                    case 0:

                        Console.WriteLine("Usted desea ingresar dinero a su cuenta.");
                        Console.WriteLine("Ingrese el monto que desea ingresar.");
                        clienteUno.Depositar(monto= Convert.ToDecimal(Console.ReadLine()));
                        Console.WriteLine("Operacion realizada exitosamente.");
                        break;

                    case 1:

                        Console.WriteLine("Usted desea retirar dinero a su cuenta.");
                        Console.WriteLine("Ingrese el monto que desea retirar.");
                        clienteUno.Extraer(monto = Convert.ToDecimal(Console.ReadLine()));
                        Console.WriteLine("Operacion realizada exitosamente.");

                        break;
                    case 2:

                        Console.WriteLine("Usted desea ver el dinero de su cuenta.");
                        
                        Console.WriteLine("Usted posee {0}",clienteUno.RetornarMonto());
                        Console.WriteLine("Operacion realizada exitosamente.");

                        break;

                    default:

                        Console.WriteLine("Opcion incorrecta");

                        break;
                }

                Console.WriteLine("Ingrese 0 para ingresar dinero a su cuenta.");
                Console.WriteLine("Ingrese 1 para retirar dinero de su cuenta.");
                Console.WriteLine("Ingrese 2 para ver el dinero de su cuenta.");

                opcion = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Dinero total del banco:{0}",banco.DepositosTotales());



        }
    }
}
