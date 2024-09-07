using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Direccion
    {
        public string Calle { get; private set; }
        public string Colonia { get; private set; }
        public string MunicipioCiudad { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
        public string CodigoPostal { get; private set; }

        public Direccion(string calle, string colonia, string municipioCiudad, string estado, string pais, string codigoPostal)
        {
            Calle = calle;
            Colonia = colonia;
            MunicipioCiudad = municipioCiudad;
            Estado = estado;
            Pais = pais;
            CodigoPostal = codigoPostal;
        }
    }
}
