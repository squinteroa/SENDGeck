using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Sobre : Servicio
    {
        private decimal TarifaDocumentos;

        public Sobre(decimal TarifaBase, decimal tarifaDocumento) : base("Sobre", TarifaBase)
        {
            TarifaDocumentos = tarifaDocumento;
        }

        public override decimal CalcularTarifa(float peso)
        {
            return TarifaBase + TarifaDocumentos;
        }
    }
}
