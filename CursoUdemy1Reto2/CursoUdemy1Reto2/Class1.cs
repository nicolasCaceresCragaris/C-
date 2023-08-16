using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy1Reto2
{
    internal class Persona
    {
        public String Nombre { get; set; }

        public String Apellido { get; set; }

        public int Edad { get;set; }

        public Persona(string nombre) 
        {
            Nombre = nombre;        
        }
        public Persona(string nombre,string apellido): this(nombre) 
        {
            Apellido = apellido;
        }

        public Persona(string nombre,string apellido, int edad):this(nombre,apellido)
        { 
            Edad = edad;    
        }

        public void Saludar()
        {
            Console.WriteLine("{0} {1}", Nombre, Apellido);
            return;
        }

        public override string ToString()
        {
            return string.Format("Nombre:{0} Apellido:{1} Edad:{2}",Nombre, Apellido,Edad);
        }

    }
}
