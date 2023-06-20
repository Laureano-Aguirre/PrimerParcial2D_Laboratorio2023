using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Generics<T, U> : IEnumerable<Tuple<T, U>>
    {
        T[] Cliente;
        U[] Carne;

        private List<Tuple<T, U>> lista;

        public Generics()
        {
            lista = new List<Tuple<T, U>>();
        }

        public void Add(T cliente, U carne)
        {
            lista.Add((Tuple.Create(cliente, carne)));
        }

        //public string MostrarVentas()
        //{

        //}

        public IEnumerator<Tuple<T, U>> GetEnumerator()
        {
            return lista.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
