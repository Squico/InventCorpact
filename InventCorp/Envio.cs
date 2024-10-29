using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventCorp
{   public class Envio
    {
        public string NumeroEnvio { get; set; }
        public string Destinatario { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }

        public Envio(string numeroEnvio, string destinatario, string direccion, string estado)
        {
            NumeroEnvio = numeroEnvio;
            Destinatario = destinatario;
            Direccion = direccion;
            Estado = estado;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Número de Envío: {NumeroEnvio}, Destinatario: {Destinatario}, Dirección: {Direccion}, Estado: {Estado}");
        }
    }

    public class SistemaLogistica
    {
        public List<Envio> Envios { get; private set; }

        public SistemaLogistica()
        {
            Envios = new List<Envio>();
        }

        public void AgregarEnvio(Envio envio)
        {
            Envios.Add(envio);
            Console.WriteLine("Envío agregado con éxito.");
        }

        public Envio BuscarEnvio(string numeroEnvio)
        {
            foreach (var envio in Envios)
            {
                if (envio.NumeroEnvio == numeroEnvio)
                    return envio;
            }
            throw new Exception("Envío no encontrado.");
        }

        public void ActualizarEstadoEnvio(string numeroEnvio, string nuevoEstado)
        {
            var envio = BuscarEnvio(numeroEnvio);
            envio.Estado = nuevoEstado;
            Console.WriteLine("Estado del envío actualizado con éxito.");
        }

        public void MostrarTodosLosEnvios()
        {
            foreach (var envio in Envios)
            {
                envio.MostrarDetalles();
            }
        }
    }
}
