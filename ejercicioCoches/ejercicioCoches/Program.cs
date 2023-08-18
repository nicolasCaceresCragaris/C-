using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioCoches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string marca;
            string modelo;
            float km;
            decimal precio;

            Console.WriteLine("Ingrese id");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese marca");
            marca= Console.ReadLine();

            Console.WriteLine("Ingrese modelo");
            modelo= Console.ReadLine();

            Console.WriteLine("Ingrese km");
            km=float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese precio");
            precio=decimal.Parse(Console.ReadLine());

            Coche cocheUno = new Coche(id,marca,modelo,km,precio);

            Console.WriteLine(cocheUno.ToString());


        }
    }
}
