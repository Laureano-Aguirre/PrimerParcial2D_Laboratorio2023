using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Cliente:Persona
    {
        private double monto;

        public Cliente(string correo, string password, double monto):base(correo,password)
        {
             this.monto = monto;
        }
    }
}
