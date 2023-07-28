using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    public class clsClients: clsPersonas
    {
        #region Propiedades
        public string Rfc { get; set; } // agrego prop y del doy doble tab para el autocoplet
        public int idClient 
        {
            get { return IdPerson;} 
            set { IdPerson = value; }
            
        } // Defino un accesor: "idClient" para poder accesar al "idPerson";


        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public override string ToString()
        {
            string cadena = $"idCliente = { idClient.ToString()} Nombre completo = {FullName} Rfc = {Rfc}";
            return cadena;
        }
        #endregion

    }
}
