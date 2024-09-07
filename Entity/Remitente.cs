using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Remitente : Cliente
    {
        public string Departamento { get; set; }

        public Remitente(string nombre, string telefono, string departamento) : base(nombre, telefono)
        {
            Departamento = departamento;
        }
    }
}
