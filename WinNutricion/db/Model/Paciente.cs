using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class Paciente
    {
        #region variables locales
        private int _dni;
        private string _nombre;
		private string _apellido;
        private string _domicilio;        
		private string _telefono;
		private DateTime _fechaAlta;
		private DateTime _fechaNac;
		private double _pesoInicial;
		private double _talla;
        #endregion

        #region propiedades publicas
        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        
        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }     
		
		public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
		
		public double PesoInicial
        {
            get { return _pesoInicial; }
            set { _pesoInicial = value; }
        }

        public double Talla
        {
            get { return _talla; }
            set { _talla = value; }
        }
		
		public DateTime FechaAlta
        {
            get { return _fechaAlta; }
            set { _fechaAlta = value; }
        }
		
		public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }
        #endregion

    }
}
