using System;
using Ferreteria_MAX.Models;


namespace Ferreteria_MAX.Controlador
{
    public class ControladorCliente
    {
        private List<Cliente> clientes = new List<Cliente>();

        public void RegistrarCliente(Cliente client)
        {
            clientes.Add(client);
            Console.WriteLine("Cliente registrado exitosamente.");
        }

        public void ActualizarClientes(Cliente client)
        {
            var existeCliente = clientes.Find(c => c.ID == client.ID);
            if (existeCliente != null)
            {
                existeCliente.Nombre = client.Nombre;
                existeCliente.Apellido = client.Apellido;
                existeCliente.Nacionalidad = client.Nacionalidad;
                existeCliente.Correo = client.Correo;
                existeCliente.Telefono = client.Telefono;
                Console.WriteLine("Cliente actualizado exitosamente.");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }

        public List<Cliente> GetClients()
        {
            return clientes;
        }

        public void HistoricoCompraCliente(string clienteId)
        {
            var client = clientes.Find(c => c.ID == clientId);
            if (client != null)
            {
                Console.WriteLine($"Histórico de compras para {client.Nombre} {client.Apellido}:");
                foreach (var venta in client.HistorialCompras)
                {
                    Console.WriteLine($"Venta ID: {venta.VentaID}, Fecha: {venta.Fecha}, Método de Pago: {venta.MetodoPago}");
                }
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }
    }
}
