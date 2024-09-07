using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Destinatario : Cliente
    {
        public string Compania { get; set; }
        public Direccion Direccion { get; protected set; }
        public Destinatario(string nombre, string telefono, string compania) : base(nombre, telefono)
        {
            Compania = compania;
        }
        public void CrearDireccion (Direccion direccion) { Direccion = direccion; }
    }
}

