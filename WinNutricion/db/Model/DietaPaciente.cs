using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class DietaPaciente
    {
        public DietaPaciente()
        {
            this.Fecha = DateTime.Now;
        }
        
        #region variables locales
        private int _codigo;
		private int _codigoDieta;
		private int _dniPaciente;
        private DateTime _fecha;
		private DateTime _fechaFin;
        //variables locales para manejar las relaciones con otras clases
        private Paciente _paciente = null;
        private Dieta _dieta = null;

        #endregion
        
        #region propiedades publicas
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
		
		public int CodigoDieta
        {
            get { return _codigoDieta; }
            set { _codigoDieta = value; }
        }
				
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
		
		public DateTime FechaFin
        {
            get { return _fechaFin; }
            set { _fechaFin = value; }
        }

        // Implementacion de relaciones con otras clases
        public Paciente Paciente
        {
            get
            {
                if (_paciente == null)
                {
                    _paciente = new Paciente();
                    _paciente.findbykey(this.DniPaciente);
                }
                return _paciente;
            }
            set
            {
                _paciente = value;
                if (_paciente != null)
                {
                    this.DniPaciente = _paciente.Dni;
                }
            }
        }
        public Dieta Dieta
        {
            get
            {
                if (_dieta == null)
                {
                    _dieta = new Dieta();
                    _dieta.findbykey(this.CodigoDieta);
                }
                return _dieta;
            }
            set
            {
                _dieta = value;
                if (_dieta != null)
                    this._codigoDieta = _dieta.Codigo;
            }
        }
        
        #endregion
        
    }
}
