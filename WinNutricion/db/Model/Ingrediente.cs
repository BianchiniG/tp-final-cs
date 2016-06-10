using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class Ingrediente
    {
        private int _codigo;
        private string _nombre;
		
		
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _unidadMedida;

        public string UnidadMedida
        {
            get { return _unidadMedida; }
            set { _unidadMedida = value; }
        }
        
    }
}
