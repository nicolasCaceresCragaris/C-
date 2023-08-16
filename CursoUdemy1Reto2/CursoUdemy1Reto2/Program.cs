using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy1Reto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Eduardo", "Alfaro", 30);
            Persona personaDos = new Persona("German", "Cano", 40);



            personaUno.Saludar();
            personaDos.Saludar();

            Console.WriteLine(personaUno.ToString());
            Console.WriteLine(personaDos.ToString());
        }

    }
}
