using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBanco
{
    internal class Banco
    {
        public Cliente ClienteUno { get; set; }
        public Cliente ClienteDos { get; set; }
        public Cliente ClienteTres { get; set; }

        #region constructores

        public Banco (Cliente clienteUno)
        {
            
            ClienteUno = clienteUno;
        }

        public Banco(Cliente clienteUno, Cliente clienteDos) : this(clienteDos)
        {

            ClienteDos = clienteDos;
            
        }
        public Banco(Cliente clienteUno, Cliente clienteDos, Cliente clienteTres) : this(clienteUno)
        {
            ClienteTres = clienteTres;
        }

        #endregion

        public decimal DepositosTotales()
        {
            return ClienteUno.RetornarMonto()+ClienteDos.RetornarMonto()
                +ClienteTres.RetornarMonto();   
        }
        
     

    }
}
