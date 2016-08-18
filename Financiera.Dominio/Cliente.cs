using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financiera.Dominio
{
    public class Cliente
    {
        public int CodigoCliente {get; set; }
      
        public int NombreCliente { get; set; }

        public int TipoCliente { get; set; }

        public void Daralta(String as_nombre , byte aby_tipo)
        {
            return new Cliente()
            {
                NombreCliente = as_nombre ,
                TipoCliente = aby_tipo
            };
        }

        public void ModificarNombre(String as_nombre)
        {
     
        }
    }
}