using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Caja : Servicio
    {
        private decimal TarifaVolumen;

        public Caja(decimal TarifaBase, decimal tarifaVolumen) : base("Caja", TarifaBase)
        {
            TarifaVolumen = tarifaVolumen;
        }

        public override decimal CalcularTarifa(float peso)
        {
            return TarifaBase * (decimal)peso + TarifaVolumen;
        }
    }
}
