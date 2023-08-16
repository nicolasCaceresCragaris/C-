using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBanco
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public decimal MontoTotal { get; set; }

        public decimal MontoIngresar { get; set; }

        #region constructores
        public Cliente(string nombre)
        {
            Nombre = nombre;
        }
        public Cliente(string nombre, decimal montoTotal) : this(nombre)
        {
            MontoTotal = montoTotal;
        }
     
        public Cliente(){}

        #endregion

        public void Depositar(decimal montoIngresar)
        {
            if (montoIngresar >= 0)
            {
                MontoTotal += montoIngresar;


            }
            else
            {
                MontoTotal += 0;
            }
            return;
        }

        public decimal Extraer(decimal montoExtraer)
        {
            decimal dinero = 0;
            
            if (montoExtraer<=MontoTotal) 
            {
              
                MontoTotal = MontoTotal- montoExtraer;
                dinero = montoExtraer;

            }
            else
            {
                Console.WriteLine("No se puede extraer el monto ingresado.");
            }

            return dinero;
        }

        public decimal RetornarMonto()
        {
            Console.WriteLine("Su monto es: {0}",MontoTotal);
            return MontoTotal;
        }

    }
}
