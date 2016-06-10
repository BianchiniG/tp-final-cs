using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class PlatoPaciente
    {
        public PlatoPaciente()
        {
            this.Fecha = DateTime.Now;
        }
        private int _codigoPlato;
		private int _dniPaciente;
        private float _cantidad;
		private DateTime _fecha;
		
        public float Cantidad	
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public int DniPaciente
        {
            get { return _dniPaciente; }
            set { _dniPaciente = value; }
        }
		
		public int CodigoPlato
        {
            get { return _codigoPlato; }
            set { _codigoPlato = value; }
        }
		
		
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        
    }
}
