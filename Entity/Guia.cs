using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Guia
    {
        public int NumeroGuia { get; set; }
        public float Peso { get; set; }
        public decimal ValorDeclarado { get; set; }
        public bool Internacional { get; set; }
        public string EstadoGuia { get; set; } = "DESPACHO";
        public Destinatario Destinatario { get; set; }
        public Remitente Remitente { get; set; }
        public Servicio TipoServicio { get; set; }

        private readonly ICalculadorCosto _calculadorCosto;

        public Guia(ICalculadorCosto calculadorCosto)
        {
            _calculadorCosto = calculadorCosto;
        }

        public void RegistrarEntrega()
        {
            EstadoGuia = "FINALIZADA";
            decimal costo = _calculadorCosto.CalcularCosto(this);
            Console.WriteLine($"Entrega registrada. Costo del servicio: {costo:C}");
        }

        public string ConsultarEstado()
        {
            return EstadoGuia;
        }
    }
}
