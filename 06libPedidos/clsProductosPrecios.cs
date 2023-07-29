using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    public class clsProductosPrecios : clsProductos
    {
        //Esta clase hereda
        #region Propiedades

        public decimal PrecioPublico { get; set; }
        public decimal PrecioMayoreo { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal PorcentajeIeps { get; set; }


        #endregion

        #region Constructor
        #endregion

        #region Metodos
        // Agrego un metodo ToString para que pueda imprimir las propiedades de mi clase
        public override string ToString()
        {
            return base.ToString() +
                $"Precio públco: {PrecioPublico.ToString("C")}" + // Concateno cadenas interpoladas, la "C" es para dar formato y que salga con sino de pesos.
                $"Precio mayoreo: {PrecioMayoreo.ToString("C")}" +
                $"Porcentaje Iva: {PorcentajeIva.ToString()}" +
                $"Porcentaje Ieps: {PorcentajeIeps.ToString()}";
        }

        public decimal DesglosaImpuestos(out decimal MontoIva, out decimal MontoIeps)
        {
            decimal resultado = 0;
            resultado = clsCalculoPrecios.DesglosaImpuestos(PrecioPublico, PorcentajeIva, PorcentajeIeps,
                                                out MontoIva, out MontoIeps);
            return resultado;
        }


        #endregion
    }
}

