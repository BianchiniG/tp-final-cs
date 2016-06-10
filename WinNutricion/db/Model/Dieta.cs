using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class Dieta
    {
        #region variables locales
        private int _codigo;
        private string _nombre;
		private string _autor;
		private string _descripcion;
        private DateTime _fechaAlta;
        #endregion
        
        #region propiedades publicas
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
		
		public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }
		
		public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        
        public DateTime FechaAlta
        {
            get { return _fechaAlta; }
            set { _fechaAlta = value; }
        }
        #endregion
        
    }
}
