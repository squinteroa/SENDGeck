using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Paquete : Servicio
    {
        public Paquete(decimal TarifaBase) : base("Paquete", TarifaBase) { }

        public override decimal CalcularTarifa(float peso)
        {
            return TarifaBase * (decimal)peso;
        }
    }
}
