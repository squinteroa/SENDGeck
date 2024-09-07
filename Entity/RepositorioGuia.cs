using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RepositorioGuia : IRepositorioGuia
    {
        private readonly ICollection<Guia> _collection;

        public RepositorioGuia()
        {
            _collection = new List<Guia>();
        }

        public void AgregarGuia(Guia guia)
        {
            _collection.Add(guia);
        }

        //public List<Guia> ConsultaGeneral()
        //{
        //    return _collection
        //}

        public Guia ConsultarGuiaNumeroGuia(int numeroGuia)
        {
            foreach (var guia in _collection)
            {
                if (guia.NumeroGuia == numeroGuia)
                {
                    return guia;
                }
            }
            return null;
        }

        public List<Guia> ConsultarGuiasPorEstado(string estado)
        {
            var guias = new List<Guia>();

            foreach (var guia in _collection)
            {
                if (guia.EstadoGuia == estado)
                {
                    guias.Add(guia);
                }
            }

            return guias;
        }
    }
}
