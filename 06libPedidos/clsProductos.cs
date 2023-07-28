using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    public class clsProductos
    {
        #region Propiedades
        public int idProducto { get; set; }
        public string Description { get; set; }

        public string CodigoBarras { get; set; }

        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public override string ToString() // Sobreescribir el ToString()
        {
            return $"idProducto: {idProducto.ToString()} " +
                $"Descripción {Description} " +
                $"Codigo de barras {CodigoBarras}";
        }

        #endregion

    }
}
