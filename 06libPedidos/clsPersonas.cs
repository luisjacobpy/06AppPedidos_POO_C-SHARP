using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos // Corresponde al nombre del proyecto
{
    public class clsPersonas // 'internal' para que solo se vea dentro del assembly
    {
        #region Propiedades
        private int _idPerson; // Defino propiedades a traves de campos que son privados
        private string _FullName;

        protected int IdPerson { // lo cambio de public > protected, permite a las calses derivadas acceder a las clases derivadas, pero a las demás clases no puedo acceder.
            get => _idPerson; 
            set => _idPerson = value; 
        }
        public string FullName { 
            get => _FullName; 
            set => _FullName = value; 
        }

        #endregion

        #region Constructor
        // Aqui defino el constructor, aqui puedo inicializar mis campos
        public clsPersonas() { 
            _idPerson = 0;
            _FullName = string.Empty;
        }

        #endregion

        #region Metodos
        #endregion

    }
}
