using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public interface IRepositorioGuia
    {
        void AgregarGuia(Guia guia);
        Guia ConsultarGuiaNumeroGuia(int numeroGuia);
        List<Guia> ConsultarGuiasPorEstado(string estado);
    }
}
