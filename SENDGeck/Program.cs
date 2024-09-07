using Entity;
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
            // Creación de tres objetos Remitente con diferentes datos
            Remitente remitente1 = new Remitente("John Doe", "123456789", "Ventas");
            Remitente remitente2 = new Remitente("Maria Perez", "987654321", "Compras");
            Remitente remitente3 = new Remitente("Carlos Ramirez", "456789123", "Logística");

            // Creación de tres objetos Destinatario con diferentes datos y direcciones
            Destinatario destinatario1 = new Destinatario("Acme Corp", "123456789", "Gekon System");
            Direccion direccion1 = new Direccion("Av. Principal 123", "Centro", "Ciudad XYZ", "Estado ABC", "País DEF", "12345");
            destinatario1.CrearDireccion(direccion1);

            Destinatario destinatario2 = new Destinatario("Globex Corp", "987654321", "Core Services");
            Direccion direccion2 = new Direccion("Calle Secundaria 456", "Norte", "Ciudad MNO", "Estado DEF", "País GHI", "67890");
            destinatario1.CrearDireccion(direccion2);

            Destinatario destinatario3 = new Destinatario("Initech LLC", "456789123", "Systems Integration");
            Direccion direccion3 = new Direccion("Blvd. Industrial 789", "Este", "Ciudad PQR", "Estado GHI", "País JKL", "11223");
            destinatario1.CrearDireccion(direccion3);

            Console.WriteLine("Direccion: " + destinatario1.Direccion);

            Servicio servicio1 = new Caja(5000,25000);
            Servicio servicio2 = new Sobre(5000,10000);
            Servicio servicio3 = new Paquete(5000);

            // Crear una guía
            Guia guia1 = new Guia(1001, 2.5f, 1500.75m, false, destinatario1, remitente1, servicio1);
            Guia guia2 = new Guia(1002, 5.0f, 3000.00m, true, destinatario2, remitente2, servicio2);
            Guia guia3 = new Guia(1003, 1.2f, 500.00m, false, destinatario3, remitente3, servicio3);

            // Crear un repositorio de guías
            IRepositorioGuia repositorioGuia = new RepositorioGuia();

            // Agregar la guía al repositorio
            repositorioGuia.AgregarGuia(guia1);
            repositorioGuia.AgregarGuia(guia2);
            repositorioGuia.AgregarGuia(guia3);

            Console.WriteLine("CONSULTAR ESTADO GUIAS");
            foreach(Guia guia in repositorioGuia.ConsultarGuiasPorEstado("DESPACHO"))
            {
                Console.WriteLine($"Guía {guia.NumeroGuia} - Estado: {guia.EstadoGuia}");
            }


            Console.WriteLine("ENTREGA FINALIZADA");
            //foreach(Guia guia in repositorioGuia.ConsultaGeneral())
            guia1.FinalizarEntrega();
            guia2.FinalizarEntrega();
            guia3.FinalizarEntrega();

            Console.WriteLine("CONSULTAR ESTADO GUIAS");
            foreach (Guia guia in repositorioGuia.ConsultarGuiasPorEstado("FINALIZADA"))
            {
                Console.WriteLine($"Guía {guia.NumeroGuia} - Estado: {guia.EstadoGuia}");
            }


            Console.WriteLine("CONSULTAR GUIAS POR NUMERO DE GUIA");
            // Consultar guías por destinatario
            Console.WriteLine(repositorioGuia.ConsultarGuiaNumeroGuia(guia1.NumeroGuia).NumeroGuia);
            Console.WriteLine(repositorioGuia.ConsultarGuiaNumeroGuia(guia2.NumeroGuia).NumeroGuia);
            Console.WriteLine(repositorioGuia.ConsultarGuiaNumeroGuia(guia3.NumeroGuia).NumeroGuia);

            Console.ReadLine();
        }
    }
}
