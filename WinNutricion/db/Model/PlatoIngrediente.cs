using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class PlatoIngrediente
    {
        private int _codigoPlato;
		private int _codigoIngrediente;
        private float _cantidad;
		
        public float Cantidad	
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public int CodigoIngrediente
        {
            get { return _codigoIngrediente; }
            set { _codigoIngrediente = value; }
        }
		
		public int CodigoPlato
        {
            get { return _codigoPlato; }
            set { _codigoPlato = value; }
        }
        
    }
}
