global using _06libPedidos; // Son librerias globales, primero se ponen los global
using _06AppPedidos;

int opcion = 0;
// Crear menu de opciones, colocar dentro de un ciclo do while

do
{
    Console.WriteLine("Menu de opciones");
    Console.WriteLine();
    Console.WriteLine("1. Ejmeplo de cliente");
    Console.WriteLine("2. Ejmeplo de record de productos");
    Console.WriteLine("3. Ejmeplo de record de paso de parametros a un Método");
    Console.WriteLine("4. Ejemplo de Colecciones clientes");
    Console.WriteLine("5. Ejemplo de Diccionario de productos");

    Console.WriteLine("20. Salir");
    opcion = Convert.ToInt32(Console.ReadLine()); // Para ingresar y convertir el valor de string a int
    // Utilizamos un switch
    switch (opcion)
    {
        case 1: // En caso de que sea uno voy a llamar a las funciones principales
            FuncionesPrincipales.EjemploCliente(); // Recordar usar el name space, es decir el using de arriga
            break; // En cada case, tengo que colocar el break que sirve para salir de un bloque

        case 2:
            FuncionesPrincipales.EjenploRecordProducto();
            break;

        case 3:
            FuncionesPrincipales.EjemploDesglosaImpuestos();
            break;
        default:
            break;

        case 4:
            FuncionesPrincipales.EjemploColeccionesClientes();
            break;
        case 5:
            FuncionesPrincipales.EjemploDiccionario();
            break;
    }
} while (opcion != 20);


