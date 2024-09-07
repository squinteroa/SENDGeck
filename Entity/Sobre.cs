using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Sobre : Servicio
    {
        private decimal tarifaDocumentos;

        public Sobre() : base("Sobre", 5000)
        {
            tarifaDocumentos = 10000;
        }

        public override decimal CalcularTarifa(float peso)
        {
            return TarifaBase + tarifaDocumentos;
        }
    }
}
