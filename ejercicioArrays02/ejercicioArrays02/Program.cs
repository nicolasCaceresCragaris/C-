using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioArrays02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ej 1
            //EJERCICIO 1
            // Crea un array de 10 posiciones, con valores puestos por ti y muestra el array.
            Console.WriteLine("EJERCICIO NUMERO 1");

            int[] vectorUno = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < vectorUno.Length; i++)
            {
                Console.WriteLine(vectorUno[i]);
            }

            Console.WriteLine("==================================");
            #endregion

            #region Ej 2
            //EJERCICIO2
            //Crea un array de 10 posiciones, pide los valores por consola y muestra el array.
            int[] vectorDos = new int[10];
            Console.WriteLine("Ejercicio 2");

            for (int i = 0; i < vectorDos.Length; i++)
            {
                Console.WriteLine("Ingrese 10 valores");
                vectorDos[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < vectorDos.Length; i++)
            {
                Console.WriteLine(vectorDos[i]);
            }

            Console.WriteLine("==================================================");

            #endregion

            #region Ej 3
            //EJERCICIO 3
            // Sumar los valores de un array y mostrar el resultado.

            int suma = 0;

            for (int i = 0; i < vectorUno.Length; i++)
            {
                suma += vectorUno[i];
            }
            Console.WriteLine("Suma:{0}",suma);
            Console.WriteLine("==============================================");
            #endregion

            #region Ej 4
            //EJERCICIO 4
            //Dado un array de numeros con el metodo Sort, ordenalos y muestra su contenido.

            Array.Sort(vectorDos);
            for(int i=0;i<vectorDos.Length;i++)
            {
                Console.WriteLine(vectorDos[i]);
            }

            #endregion
        }
    }
}
