using System;
using Ferreteria_MAX.Models;



namespace Ferreteria_MAX.Controlador
{
    public class ControladorInventario
    {
        private List<Producto> productos = new List<Producto>();

        public void AddProducto(Producto productos)
        {
            productos.Add(product);
            Console.WriteLine("Producto agregado exitosamente.");
        }

        public void EditProducto(Producto productos)
        {
            var existeProducto = productos.Find(p => p.Nombre == productos.Nombre);
            if (existeProducto != null)
            {
                existeProducto.Cantidad = productos.Cantidad;
                existeProducto.Precio = productos.Precio;
                Console.WriteLine("Producto editado exitosamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public void EliminarProducto(string nombreproducto)
        {
            var product = productos.Find(p => p.Nombre == nombreproducto);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine("Producto eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public List<Producto> GetProducts()
        {
            return productos;
        }

        public void CheckInventario()
        {
            foreach (var product in productos)
            {
                if (product.Quantity < 5) // inventario bajo
                {
                    Console.WriteLine($"Producto {product.Name} tiene inventario bajo.");
                }
            }
        }
    }
}
