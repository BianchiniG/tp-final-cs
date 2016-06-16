using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class Profesional : CommonObj, IAccessDB<Profesional>, ITable
    {
        private string[] _columns = { "dni","matricula","nombre","apellido","telefono","fecha_alta","es_med","es_nutri"};
        public List<Profesional> findAll()
        {
            return this.findAll(null);
        }
        public List<Profesional> findAll(string criterio)
        {
            return ManagerDB<Profesional>.findAll(criterio);
        }
        public Profesional findbykey(params object[] key)
        {
            Profesional p = (Profesional)ManagerDB<Profesional>.findbyKey(key);
            if (p != null)
            {
                this.Nombre = p.Nombre;
                this.Apellido = p.Apellido;
                this.Domicilio = p.Domicilio;
                this.Dni = p.Dni;
                this.FechaAlta = p.FechaAlta;
                this.Telefono = p.Telefono;
                this.EsMedico = p.EsMedico;
                this.EsNutricionista = p.EsNutricionista;
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
            return ManagerDB<Profesional>.saveObject(this);
        }

        public string TableName
        {
            get { return "profesional"; }
        }

        public string KeyTable
        {
            get { return "dni"; }
        }

        public void initialize(System.Data.DataRow dr)
        {
            this._dni = Int32.Parse(dr[_columns[0]].ToString());
            this._matricula = dr[_columns[1]].ToString().Trim();
            this._nombre = dr[_columns[2]].ToString().Trim();
			this._apellido = dr[_columns[3]].ToString().Trim();
            this._telefono = dr[_columns[4]].ToString().Trim();
            if (dr[_columns[5]] != DBNull.Value)
                this._fechaAlta = DateTime.Parse(dr[_columns[5]].ToString());
            if (Int32.Parse(dr[_columns[6]].ToString()) == 0)
            {
                this._esMedico = false;
            }
            else
            {
                this._esMedico = true;
            }
            if (Int32.Parse(dr[_columns[6]].ToString()) == 0)
            {
                this._esNutricionista = false;
            }
            else
            {
                this._esNutricionista = true;
            }
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
                                (this.IsNew?"":_columns[2] + "=")+String.Format("'{0}'",this._matricula), //formato cadena ''
                                (this.IsNew?"":_columns[3] + "=")+String.Format("'{0}'",this._apellido),//formato cadena ''
                                (this.IsNew?"":_columns[4] + "=")+String.Format("'{0}'",this._domicilio),//formato cadena ''
                                (this.IsNew?"":_columns[5] + "=")+String.Format("'{0}'",this._telefono),//formato cadena ''
                                (this.IsNew?"":_columns[6] + "=")+String.Format("'{0}'",this._fechaAlta.ToString("yyyy-MM-dd")),//formato cadena ''
                                (this.IsNew?"":_columns[7] + "=")+this.EsMedico.ToString().ToLower(),
                                (this.IsNew?"":_columns[7] + "=")+this.EsNutricionista.ToString().ToLower()
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
