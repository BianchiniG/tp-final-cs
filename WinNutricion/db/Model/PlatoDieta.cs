using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class PlatoDieta
    {
        private int _codigoPlato;
		private int _codigoDieta;
        private float _porcion;
        public float Porcion	
        {
            get { return _porcion; }
            set { _porcion = value; }
        }

        public int CodigoDieta
        {
            get { return _codigoDieta; }
            set { _codigoDieta = value; }
        }
		
		public int CodigoPlato
        {
            get { return _codigoPlato; }
            set { _codigoPlato = value; }
        }
        
    }
}
