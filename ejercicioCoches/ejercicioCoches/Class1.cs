using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioCoches
{
    internal class Coche
    {
        private int Id { get; set; }
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private float Km { get; set; }
        private decimal Precio { get; set; }

        public Coche(int id, string marca, string modelo, float km, decimal precio)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Km = km;
            this.Precio = precio;

        }

        public override string ToString()
        {
            return string.Format("Marca:{0} Modelo:{1} Id:{2} Km:{3} Precio:{4}",Id,Marca,Modelo,Km,Precio);
        }
    }

}
