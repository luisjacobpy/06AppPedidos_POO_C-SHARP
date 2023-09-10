# AppPedidos
<hr>

<p align="center">
   <img src="http://img.shields.io/static/v1?label=STATUS&message=IN%20PROGRESS&color=RED&style=for-the-badge" #vitrinedev/>
</p>



![image.net](https://github.com/luisjacobpy/06AppPedidos_POO_C-SHARP/blob/main/CSHARP.jpeg).

# Aplicación de Ejemplos en C#

Este repositorio contiene ejemplos de código en C# que cubren varios conceptos y funcionalidades. Estos ejemplos están organizados en funciones principales que se pueden ejecutar desde un menú de opciones.

## Requisitos

Asegúrate de tener instalado el entorno de desarrollo de C# en tu máquina antes de ejecutar estos ejemplos.
En el programa utilizo NET06, asegurate de utilizar NET06 o suerior. 

## Ejecución

Puedes ejecutar la aplicación a través de un ciclo de menú que te permite seleccionar las diferentes funciones de ejemplo. Sigue las instrucciones en pantalla para interactuar con cada ejemplo. Aquí hay una breve descripción de las opciones disponibles en el menú:

1. Ejemplo de cliente: Muestra cómo crear y trabajar con un objeto de cliente.
2. Ejemplo de record de productos: Ilustra el uso de registros (records) para representar productos.
3. Ejemplo de desglose de impuestos: Calcula y muestra el desglose de impuestos para un producto.
4. Ejemplo de colecciones de clientes: Permite agregar, mostrar y eliminar clientes en una lista.
5. Ejemplo de diccionario de productos: Demuestra el uso de un diccionario para gestionar productos.

## Estructura del Proyecto

- **_06AppPedidos**: Contiene las funciones principales de la aplicación.
- **_06libPedidos**: Contiene las clases y registros utilizados por la aplicación.

## Contribución

Siéntete libre de contribuir a este repositorio agregando más ejemplos o mejorando los existentes. Las contribuciones son bienvenidas.

¡Diviértete explorando los ejemplos de C#! Si tienes alguna pregunta o sugerencia, no dudes en ponerte en contacto!

## Conocimientos de C# y .NET aplicados

El código proporcionado contiene varios conceptos y características de C# aplicados en diferentes partes del código. Aquí tienes una lista de algunos de los conceptos y características de C# que se aplican en el código:

1. **Uso de Namespaces:** El código utiliza el concepto de namespaces para organizar y agrupar clases y registros relacionados. Por ejemplo, se usan los namespaces `_06libPedidos` y `_06AppPedidos` para organizar las clases y registros en diferentes archivos.

2. **Declaración y Uso de Variables:** Se declaran y utilizan variables en todo el código para almacenar datos como números, cadenas y objetos.

3. **Estructuras de Control:** Se utilizan estructuras de control como bucles `do-while` y sentencias `switch-case` para crear un menú interactivo que permite al usuario seleccionar diferentes opciones.

4. **Métodos:** Se definen métodos estáticos en la clase `FuncionesPrincipales` para encapsular la lógica relacionada con cada opción del menú. Los métodos también se llaman y utilizan para ejecutar acciones específicas.

5. **Herencia de Clases:** Se utiliza la herencia de clases en la relación entre `clsClients` y `clsPersonas`. La clase `clsClients` hereda de la clase `clsPersonas`, lo que significa que `clsClients` hereda sus propiedades y métodos.

6. **Encapsulación:** Las propiedades de las clases se encapsulan utilizando getters y setters, y algunas propiedades se declaran como públicas para permitir el acceso desde otras partes del código.

7. **Uso de Registros (Records):** Se crean registros (records) para representar objetos de datos inmutables. Por ejemplo, se utiliza un registro llamado `recProductos` para representar productos con propiedades inmutables.

8. **Interfaces:** Se utiliza una interfaz llamada `intRepositorioProductos` en el código para definir un contrato que debe ser implementado por otras clases. Esto es un ejemplo de cómo se utiliza la interfaz en C#.

9. **Colecciones:** Se utilizan colecciones como `List<clsClients>` y `Dictionary<string, recProductos>` para almacenar y manipular datos, como la lista de clientes y el diccionario de productos.

10. **Manejo de Excepciones:** Aunque no se ve en el código proporcionado, es una buena práctica el manejo de excepciones en C# para capturar y manejar errores.

11. **Usos de `using`:** La declaración `using` se utiliza para importar y utilizar namespaces externos, lo que permite el acceso a clases y métodos definidos en esos namespaces.

12. **Constructores:** Se definen constructores en algunas clases para inicializar objetos cuando se crean instancias de esas clases.

13. **Método `ToString()`:** Se sobrescribe el método `ToString()` en algunas clases para proporcionar una representación de cadena personalizada de los objetos.

14. **Comentarios y Documentación:** Se incluyen comentarios en el código para explicar el propósito de las clases, métodos y variables. Además, se proporciona un archivo README para documentar el proyecto.

Estos son algunos de los conceptos y características de C# que se aplican en el código. Cada parte del código demuestra cómo se pueden utilizar estos conceptos para crear una aplicación funcional en C#.




