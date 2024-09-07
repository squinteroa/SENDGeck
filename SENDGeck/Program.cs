using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENDGeck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un cliente, destinatario y remitente
            Cliente cliente = new Cliente { Cedula = "123456789", Nombre = "Juan Perez", Telefono = "555-1234" };
            Destinatario destinatario = new Destinatario { Compania = "ABC Ltda", Direccion = "Calle 123", Cliente = cliente };
            Remitente remitente = new Remitente { Departamento = "Ventas", Cliente = cliente };

            // Crear un servicio de tipo sobre
            Sobre sobre = new Sobre { Nombre = "Sobre Express", TarifaBase = 5000, TarifaDocumentos = 10000 };

            // Crear una guía
            ICalculadorCosto calculadorCostoSobre = new CalculadorCostoSobre();
            Guia guia = new Guia(calculadorCostoSobre)
            {
                NumeroGuia = 1,
                Peso = 0.5f,
                ValorDeclarado = 100000,
                Internacional = false,
                Destinatario = destinatario,
                Remitente = remitente,
                TipoServicio = sobre
            };

            // Crear un repositorio de guías
            IRepositorioGuia repositorioGuia = new RepositorioGuia();

            // Agregar la guía al repositorio
            repositorioGuia.AgregarGuia(guia);

            // Registrar la entrega y consultar el estado
            guia.RegistrarEntrega();
            Console.WriteLine($"Estado de la guía: {guia.ConsultarEstado()}");

            // Consultar la guía por número
            Guia guiaConsultada = repositorioGuia.ConsultarGuia(1);
            if (guiaConsultada != null)
            {
                Console.WriteLine($"Guía consultada: {guiaConsultada.NumeroGuia}, Estado: {guiaConsultada.EstadoGuia}");
            }

            // Consultar guías por estado
            List<Guia> guiasDespachadas = repositorioGuia.ConsultarGuiasPorEstado("FINALIZADA");
            Console.WriteLine($"Número de guías finalizadas: {guiasDespachadas.Count}");
        }
    }
}
