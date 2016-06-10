using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class Plato
    {
        private int _codigo;
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        private string _detalle;
        public string Detalle
        {
            get { return _detalle; }
            set { _detalle = value; }
        }

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        
    }
}
