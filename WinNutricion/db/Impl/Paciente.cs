using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class Paciente : CommonObj, IAccessDB<Paciente>, ITable
    {
        private string[] _columns = { "dni","nombre","apellido","domicilio", "telefono","fecha_alta","fecha_nac","peso_inicial","talla" };
        public List<Paciente> findAll()
        {
            return this.findAll(null);
        }
        public List<Paciente> findAll(string criterio)
        {
            return ManagerDB<Paciente>.findAll(criterio);
        }
        public Paciente findbykey(params object[] key)
        {
            Paciente p = (Paciente)ManagerDB<Paciente>.findbyKey(key);
            if (p != null)
            {
                this.Nombre = p.Nombre;
                this.Apellido = p.Apellido;
                this.Domicilio = p.Domicilio;
                this.Dni = p.Dni;
                this.FechaAlta = p.FechaAlta;
                this.FechaNac = p.FechaNac;
                this.Telefono = p.Telefono;
                this.PesoInicial = p.PesoInicial;
                this.Talla = p.Talla;
                this.IsNew = false;
                return this;
            }
            else
            {
                return null;
            }
        }
        public bool saveObj()
        {
            return ManagerDB<Paciente>.saveObject(this);
        }

        public string TableName
        {
            get { return "paciente"; }
        }

        public string KeyTable
        {
            get { return "dni"; }
        }

        public void initialize(System.Data.DataRow dr)
        {
            this._dni = Int32.Parse(dr[_columns[0]].ToString());
            this._nombre = dr[_columns[1]].ToString().Trim();
			this._apellido = dr[_columns[2]].ToString().Trim();
            this._domicilio = dr[_columns[3]].ToString().Trim();
            this._telefono = dr[_columns[4]].ToString().Trim();
            this._fechaAlta = DateTime.Parse(dr[_columns[5]].ToString());
            this._fechaNac = DateTime.Parse(dr[_columns[6]].ToString());
            this._pesoInicial = float.Parse(dr[_columns[7]].ToString());
			this._talla = float.Parse(dr[_columns[8]].ToString());			
            this.IsNew = false;
        }
        public string[] columns
        {
            get { return _columns; }
        }
        private string[] list_values()
        {
            // "dni","nombre","apellido","domicilio", "telefono","fecha_alta","fecha_nac","peso_inicial","talla"
            string[] values = { (this.IsNew?"":_columns[0] + "=")+this._dni.ToString(),
                                (this.IsNew?"":_columns[1] + "=")+String.Format("'{0}'",this._nombre), //formato cadena ''
                                (this.IsNew?"":_columns[2] + "=")+String.Format("'{0}'",this._apellido),//formato cadena ''
                                (this.IsNew?"":_columns[3] + "=")+String.Format("'{0}'",this._domicilio),//formato cadena ''
                                (this.IsNew?"":_columns[4] + "=")+String.Format("'{0}'",this._telefono),//formato cadena ''
                                (this.IsNew?"":_columns[5] + "=")+String.Format("'{0}'",this._fechaAlta.ToString("yyyy-MM-dd")),//formato cadena ''
                                (this.IsNew?"":_columns[6] + "=")+String.Format("'{0}'",this._fechaNac.ToString("yyyy-MM-dd")), //formato cadena ''
                                (this.IsNew?"":_columns[7] + "=")+this._pesoInicial.ToString(),
                                (this.IsNew?"":_columns[8] + "=")+this._talla.ToString()
                              };
            return values;
        }

        public string SqlString
        {
            get
            {
                string vvalues = String.Join(",", this.list_values());
                string sqliu = (this.IsNew ? "insert into {0} ({1}) values ({2})" : "update  {0} set {1} where {2}");
                return String.Format(sqliu, this.TableName, (this.IsNew ? String.Join(",", _columns) : vvalues), (this.IsNew ? vvalues : String.Format("dni = {0}", this.Dni)));
            }
        }

        public void setKeyValue(object valueId)
        {
            throw new NotImplementedException();
        }

        public string sqlKeyWhere(params object[] values)
        {
            return String.Format("dni = {0}", values[0]);
        }        
    }
}
