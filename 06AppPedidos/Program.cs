﻿using _06libPedidos;

//clsClients client;

// Establecer la relacion y la dependencia
//client = new clsClients();// Constructor
//client.idClient = 1; // accesor
//client.FullName = "Luis Jacobo Hernandez";
//client.Rfc = "HECL1503";
//Console.WriteLine(client.ToString());
// Creo un accesor para poder acceder al nombre de la persona.
    
clsProductos Producto = new clsProductos(); // Creo un objeto de la clase producto
Producto.idProducto = 1; 
Producto.Description = "REF MANZANA 600 ML";
Producto.CodigoBarras = "001";

clsProductos Producto2 = new clsProductos();
Producto2 = Producto;
Producto2.CodigoBarras = "0";


// Crear un record de producto
recProductos rProducto = new recProductos(1,"REF MANZANA 600 ML", "001");
recProductos rProducto2 = rProducto with { CodigoBarras = "0"}; // Se pasan los valores excepto el codigo de barras.

// Console.WriteLine()
// Puedo omitir el ToString ya que automaticamente va a omitir
Console.WriteLine("Producto: "+ Producto);
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




