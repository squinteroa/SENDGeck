using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Servicio
    {
        public string Nombre { get; protected set; }
        public decimal TarifaBase { get; protected set; }
        public Servicio(string nombre, decimal tarifaBase)
        {
            Nombre = nombre;
            TarifaBase = tarifaBase;
        }
        public abstract decimal CalcularTarifa(float peso);
    }
}
