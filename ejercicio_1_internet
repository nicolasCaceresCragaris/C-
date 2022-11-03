using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInternet1
{
    internal class Program
    {

        /*Tienes una tienda en la vida real con 30 animales y as pensado en crear una aplicación que un usuario 
         * pueda escribir en consola el animal que desea comprarte y 
         * si se encuentra que imprima en consola "El animal si se encuentra" 
         * (Los 30 animales pueden ser los que quieras).

        Ojo: Solo puedes crear un FOR y un IF (obligatoriamente tiene que usarse esos 2)
         * 
         */
        static void Main(string[] args)
        {
            string[] animales = {"Oso","Leon","Perro","Gato","Gorrion",
                                 "Iguana","Camaleon","Canario","Ballena","Pez",
                                 "Mandril","Mono","Buho","Cucaracha","Cuervo",
                                 "Caballo","Gorila","Pavo","Gallo","Gallina" };

            string animal;

            Console.WriteLine("Ingrese el animal que desea adquirir");
            animal=Console.ReadLine();

            for(int i=0; i < animales.Length; i++)
            {
                if (animales[i] == animal)
                {
                    Console.WriteLine("El animal si se encuentra");
                    i = animales.Length;
                }
                else
                {
                    Console.WriteLine("Buscando animal..");
                }
                
         
            }

        }
    }
}
