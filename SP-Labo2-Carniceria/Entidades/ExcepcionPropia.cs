using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionPropia:Exception
    {

       

        public ExcepcionPropia(string mensaje)
            : base(mensaje)
        {

        }

        public ExcepcionPropia(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {

        }
    }

}

