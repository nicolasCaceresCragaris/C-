using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioArrays01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cantidad de notas.");
            int cantidadCalificaciones = Convert.ToInt32(Console.ReadLine());

            float promedio;
            int acumulador = 0;

            double[] calificaciones = new double[cantidadCalificaciones];

            for(int i=0; i < calificaciones.Length; i++)
            {
                Console.WriteLine("Ingrese una calificacion");
                calificaciones[i]=Convert.ToDouble(Console.ReadLine());

            }

            

            for(int i=0;i < calificaciones.Length; i++)
            {
                acumulador+=Convert.ToInt32(calificaciones[i]);

            }

            promedio = acumulador / cantidadCalificaciones;

            Console.WriteLine("Promedio:{0}", promedio);
        }
    }
}
