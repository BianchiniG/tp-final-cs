using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class PacienteProfesional
    {
        public PacienteProfesional()
        {
            this.FechaDesde = DateTime.Today;
        }
        #region variables locales
        private int _dniPaciente;
		private int _dniMedico;
        private DateTime _fechaDesde;
		private DateTime _fechaHasta;
        #endregion
        
        #region propiedades publicas
				
		public int DniPaciente
        {
            get { return _dniPaciente; }
            set { _dniPaciente = value; }
        }
		
		public int DniMedico
        {
            get { return _dniMedico; }
            set { _dniMedico = value; }
        }
        
        public DateTime FechaDesde
        {
            get { return _fechaDesde; }
            set { _fechaDesde = value; }
        }
		
        public DateTime FechaHasta
        {
            get { return _fechaHasta; }
            set { _fechaHasta = value; }
        }
		
        #endregion
        
    }
}
