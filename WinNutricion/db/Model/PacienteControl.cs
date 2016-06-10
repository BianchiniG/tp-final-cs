using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class PacienteControl
    {
        public PacienteControl()
        {
            this._fecha = DateTime.Today;
        }
        #region variables locales
        private int _dniPaciente;
        private DateTime _fecha;
		private float _peso;
        #endregion
        
        #region propiedades publicas
				
		public int DniPaciente
        {
            get { return _dniPaciente; }
            set { _dniPaciente = value; }
        }
        
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
		
		public float Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }
        #endregion
        
    }
}
