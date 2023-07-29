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
        internal static decimal DesglosaImpuestos(decimal precio, recImpuestos Porcentajes, recMontosImpuestos Montos) // Quito los out montoIva, montoIeps y los cambio por recMontosImpuestos
        {
            decimal resultado = 0;
            resultado = precio / (1 + Porcentajes.PorcentajeIva / 100m);
            Montos.MontoIva = Math.Round(resultado * (Porcentajes.PorcentajeIva / 100m));
            resultado = resultado / (1 + Porcentajes.PorcentajeIeps / 100); // Para quitarle al resultado el Iva y el Ieps
            Montos.MontoIeps = Math.Round(resultado * (Porcentajes.PorcentajeIeps / 100m));
            return Math.Round (resultado, 2); // Redondeamos resultados
        }
        #endregion

    }
}
