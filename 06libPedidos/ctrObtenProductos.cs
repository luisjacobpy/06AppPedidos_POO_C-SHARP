﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    public class ctrObtenProductos
    {
        #region Propiedades
        private intRepositorioProductos repoProductos;
        public Dictionary<string, recProductos> Productos { get; set; }
        #endregion

        #region Constructor
        // Instanciar en el constructor
        public ctrObtenProductos(intRepositorioProductos prepoProductos) // La forma de recibir la implementación es atraves del constructor, le llamo prepoProductos, para no confundirlo con mi repoProductos
        {
            repoProductos = prepoProductos; // Instacio productos
            Productos = new Dictionary<string, recProductos>();

        }
        #endregion

        #region Metodos
        public void ObtenProductos() // No regresa nada
        {
            Productos.Clear(); // Limpiar los datos de mi repositorio
            Productos = repoProductos.ObtenTodos(); // Obtener los datos del repositorio
        }

        public bool ObtenProducto(string codigobarras, out recProductos producto)  // Obtener un solo producto en la lista dado un codigo de barras
        {
            return Productos.TryGetValue(codigobarras, out producto); // Este metodo es un boolean, si encuentra el producto es True
        
        
        }

        #endregion

    }
}
