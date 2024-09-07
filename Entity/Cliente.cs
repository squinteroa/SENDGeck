using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public Cliente(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }
    }
}
