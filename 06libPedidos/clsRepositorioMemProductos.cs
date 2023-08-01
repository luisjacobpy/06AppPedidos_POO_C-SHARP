using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{   
    
    /*
     Esta clase sirve para acceder a una fuente de datos y recuperar los datos
     */
    public class clsRepositorioMemProductos 
    {
        #region Propiedades
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public Dictionary<string, recProductos> ObtenTodos()
        {
            // Creo un diccionario
            Dictionary<string, recProductos> Productos = new Dictionary<string, recProductos>();
            Productos.Add("00001", new recProductos(1, "REF MANZANA 600ML", "00001"));
            Productos.Add("00002", new recProductos(2, "DET COLOR 1 KG", "00002"));
            Productos.Add("00003", new recProductos(3, "CROQUETAS PARA PERRO 1 KG", "00003"));
            Productos.Add("00004", new recProductos(4, "CAFE EXPRESO 1 KG", "00004"));
            Productos.Add("00005", new recProductos(5, "GALLETAS DE CHOCOLATE", "00005"));
            return Productos;

        }
        #endregion

    }
}
