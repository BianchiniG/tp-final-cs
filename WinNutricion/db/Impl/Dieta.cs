using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class Dieta : CommonObj, IAccessDB<Dieta>, ITable, IAutoIncrement
    {
        private string[] _columns = { "codigo","nombre","autor","fecha_alta","descripcion" };
        public List<Dieta> findAll()
        {
            return this.findAll(null);
        }
        public List<Dieta> findAll(string criterio)
        {
            return ManagerDB<Dieta>.findAll(criterio);
        }
        public Dieta findbykey(params object[] key)
        {
            Dieta d = (Dieta)ManagerDB<Dieta>.findbyKey(key);
            this.Autor = d.Autor;
            this.Codigo = d.Codigo;
            this.Descripcion = d.Descripcion;
            this.FechaAlta = d.FechaAlta;
            this.Nombre = d.Nombre;
            this.IsNew = false;
            return this;
        }
        public bool saveObj()
        {
            return ManagerDB<Dieta>.saveObject(this);
        }

        public string TableName
        {
            get { return "dieta"; }
        }

        public string KeyTable
        {
            get { return "codigo"; }
        }

        public void initialize(System.Data.DataRow dr)
        {
            this._codigo = Int32.Parse(dr[_columns[0]].ToString());
            this._nombre = dr[_columns[1]].ToString().Trim();
			this._autor = dr[_columns[2]].ToString().Trim();
			this._fechaAlta = DateTime.Parse(dr[_columns[3]].ToString());
			this._descripcion = dr[_columns[4]].ToString().Trim();
            this.IsNew = false;
        }
        public string[] columns
        {
            get { return _columns; }
        }
        private string[] list_values()
        {
            // "codigo","nombre","autor","fecha_alta","descripcion"
            string[] values = { (this.IsNew?"":_columns[0] + "=")+this._codigo.ToString(),
                                (this.IsNew?"":_columns[1] + "=")+String.Format("'{0}'",this._nombre), //formato cadena ''
                                (this.IsNew?"":_columns[2] + "=")+String.Format("'{0}'",this._autor),//formato cadena ''
								(this.IsNew?"":_columns[3] + "=")+String.Format("'{0}'",this._fechaAlta.ToString("yyyy-MM-dd")),//formato cadena ''
								(this.IsNew?"":_columns[4] + "=")+String.Format("'{0}'",this._descripcion)//formato cadena ''
                              };
            return values;
        }

        public string SqlString
        {
            get
            {
                string vvalues = String.Join(",", this.list_values());
                string sqliu = (this.IsNew ? "insert into {0} ({1}) values ({2})" : "update  {0} set {1} where {2}");
                return String.Format(sqliu, this.TableName, (this.IsNew ? String.Join(",", _columns) : vvalues), (this.IsNew ? vvalues : String.Format("codigo = {0}", this.Codigo)));
            }
        }
        // propiedad seteada por implementar IAutoIncrement
        public void setKeyValue(object valueId)
        {
            this._codigo = Convert.ToInt32(valueId);
        }
        
        public string sqlKeyWhere(params object[] values)
        {
            return String.Format("codigo={0}", values[0]);
        }
    }
}

