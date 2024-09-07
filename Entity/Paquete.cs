using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Paquete : Servicio
    {
        public Paquete() : base("Paquete", 5000) { }

        public override decimal CalcularTarifa(float peso)
        {
            return TarifaBase * (decimal)peso;
        }
    }
}
