using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    internal static class clsCalculoPrecios // Clase estatca, protegida con internal, para que solo pueda acceder desde mi libreria de clases.
    {
        #region Propiedades
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        //Metodo que regrese precios sin impuestos, declaro como parametro los valores que necesito para el calculo.
        // Par los valores que quiero devolver declaro `out` montoIva, montoIeps
        internal static decimal DesglosaImpuestos(decimal precio, decimal porcentajeIva, decimal porcentajeIeps, out decimal montoIva, out decimal montoIeps)
        {
            decimal resultado = 0;
            resultado = precio / (1 + porcentajeIva / 100m);
            montoIva = Math.Round(resultado * (porcentajeIva / 100m));
            resultado = resultado / (1 + porcentajeIeps / 100); // Para quitarle al resultado el Iva y el Ieps
            montoIeps = Math.Round(resultado * (porcentajeIeps / 100m));
            return Math.Round (resultado, 2); // Redondeamos resultados
        }
        #endregion

    }
}
