using _06libPedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06AppPedidos
{
    public static class FuncionesPrincipales // Clase estatica
    {
        #region Propiedades
        #endregion

        #region Constructor
        #endregion

        #region Metodos

        public static void EjemploCliente() { // El metodo debe de ser estatico

            clsClients client;
            client = new clsClients();// Constructor
            client.idClient = 1; // accesor
            client.FullName = "Luis Jacobo Hernandez";
            client.Rfc = "HECL1503";
            Console.WriteLine(client.ToString());
        }

        public static void EjenploRecordProducto() {

            clsProductos Producto = new clsProductos(); // Creo un objeto de la clase producto
            Producto.idProducto = 1;
            Producto.Description = "REF MANZANA 600 ML";
            Producto.CodigoBarras = "001";

            clsProductos Producto2 = new clsProductos();
            Producto2 = Producto;
            Producto2.CodigoBarras = "0";


            // Crear un record de producto
            recProductos rProducto = new recProductos(1, "REF MANZANA 600 ML", "001");
            recProductos rProducto2 = rProducto with { CodigoBarras = "0" }; // Se pasan los valores excepto el codigo de barras.

            // Console.WriteLine()
            // Puedo omitir el ToString ya que automaticamente va a omitir
            Console.WriteLine("Producto: " + Producto);
            Console.WriteLine("Producto2: " + Producto2);

            Console.WriteLine("rProducto: " + rProducto);
            Console.WriteLine("rProducto2: " + rProducto2);

            // Comparación
            if (Producto == Producto2)
                Console.WriteLine("Los objetos son iguales");
            else
                Console.WriteLine("Los objetos son diferentes");

            if (rProducto == rProducto2)
                Console.WriteLine("Los records son iguales");
            else
                Console.WriteLine("Los records son diferentes");
        }


        public static void EjemploDesglosaImpuestos()
        {
            clsProductosPrecios Producto = new clsProductosPrecios(); // Decloaro una variable de la clase ProductosPrecios
            Producto.idProducto = 1;
            Producto.Description = "REF MANZANA 600 ML";
            Producto.CodigoBarras = "001";
            Producto.PrecioPublico = 17.5m;
            Producto.PrecioMayoreo = 17;
            Producto.PorcentajeIva = 16;
            Producto.PorcentajeIeps = 8;
            decimal precioSinImpuestos, MontoIva, MontoIeps;
            Console.WriteLine(Producto);
            // Calculo el precio sin impuestos
            precioSinImpuestos = Producto.DesglosaImpuestos(out MontoIva, out MontoIeps);
            Console.WriteLine( precioSinImpuestos.ToString("C"));
            Console.WriteLine(MontoIva.ToString("C"));
            Console.WriteLine(MontoIva.ToString("C"));
            Console.WriteLine(MontoIeps.ToString("C"));



        }
        #endregion

    }
}
