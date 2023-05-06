using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tarjeta
    {

        private long numero;
        private string nombreTitular;
        private DateTime fechaVto;

        public Tarjeta(long numero, string nombreTitular, DateTime fechaVto)
        {
            this.numero = numero;
            this.nombreTitular = nombreTitular;
            this.fechaVto = fechaVto;
        }


    }
}
