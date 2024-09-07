using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Guia
    {
        public int NumeroGuia { get; protected set; }
        public float Peso { get; protected set; }
        public decimal ValorDeclarado { get; protected  set; }
        public bool EsInternacional { get; protected set; }
        public string EstadoGuia { get; protected set; }
        public Destinatario Destinatario { get; protected set; }
        public Remitente Remitente { get; protected set; }
        public Servicio TipoServicio { get; protected set; }

        public Guia(int numeroGuia, float peso, decimal valorDeclarado, bool esInternacional, Destinatario destinatario, Remitente remitente, Servicio tipoServicio)
        {
            NumeroGuia = numeroGuia;
            Peso = peso;
            ValorDeclarado = valorDeclarado;
            EsInternacional = esInternacional;
            EstadoGuia = "DESPACHO";
            Destinatario = destinatario ?? throw new ArgumentNullException(nameof(destinatario));
            Remitente = remitente ?? throw new ArgumentNullException(nameof(remitente));
            TipoServicio = tipoServicio ?? throw new ArgumentNullException(nameof(tipoServicio));
        }

        public decimal CalcularCosto()
        {
            decimal costo = TipoServicio.CalcularTarifa(Peso);
            if (EsInternacional)
            {
                costo += costo * 0.25m;
            }
            return costo;
        }

        public void FinalizarEntrega()
        {
            EstadoGuia = "FINALIZADA";
            Console.WriteLine($"Guía {NumeroGuia} finalizada. Costo total: {CalcularCosto()}");
        }
    }
}
