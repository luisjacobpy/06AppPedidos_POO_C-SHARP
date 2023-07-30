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
            decimal precioSinImpuestos, MontoIva = 0, MontoIeps = 0;
            Console.WriteLine(Producto);
            // Declaramos recMontoImpuestos
            recMontosImpuestos Montos = new recMontosImpuestos(0, 0); // Tengo que instanciarla con los valores iniciales
            // Calculo el precio sin impuestos
            precioSinImpuestos = Producto.DesglosaImpuestos(Montos);
            Console.WriteLine( precioSinImpuestos.ToString("C"));
            Console.WriteLine(Montos.ToString());
            


        }
        // Uso de colecciones
        public static void EjemploColeccionesClientes() 
        {
            List<clsClients> Clientes = new List<clsClients>(); // Coloca la calse clientes en la parte del generico
            int opcion = 0;
            do
            {
                Console.WriteLine("Opciones de la lista de clientes");
                Console.WriteLine();
                Console.WriteLine("1.Agregar cliente");
                Console.WriteLine("2. Mostrar lista");
                Console.WriteLine("3. Eliminar cliente");
                Console.WriteLine("4. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Dame los datos del cliente");
                        clsClients cliente = new clsClients(); // Objeto cliente
                        Console.WriteLine("Dame el id del cliente");
                        cliente.idClient = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dame el nombre completo del cliente");
                        cliente.FullName = Console.ReadLine();
                        Console.WriteLine("Dame el RFC del cliente");
                        cliente.Rfc = Console.ReadLine();
                        Clientes.Add(cliente); // A mi lista de clientes le agrego el cliente.
                        break;
                    case 2:
                        //Mostrar la lista de clietes
                        foreach (clsClients item in Clientes)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;
                    case 3:
                        // Eliminar cliente
                        Console.WriteLine("Dame la posición de la lista del elemento que voy a eliminar");
                        int posicion = Convert.ToInt32(Console.ReadLine());
                        Clientes.RemoveAt(posicion);// Metodo para eliminar un elemento debo idicar la posoción del elemento que debo eleiminar.
                        break;


                }
            } while (opcion != 4);
        }         
        
        #endregion

    }
}
