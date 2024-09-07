using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Caja : Servicio
    {
        private decimal tarifaVolumen;

        public Caja() : base("Caja", 5000)
        {
            tarifaVolumen = 25000;
        }

        public override decimal CalcularTarifa(float peso)
        {
            return TarifaBase * (decimal)peso + tarifaVolumen;
        }
    }
}
