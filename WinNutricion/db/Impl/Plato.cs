using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class Plato : CommonObj, IAccessDB<Plato>, ITable
    {
        private string[] _columns = { "codigo","nombre","detalle" };
        public List<Plato> findAll()
        {
            return this.findAll(null);
        }
        public List<Plato> findAll(string criterio)
        {
            return ManagerDB<Plato>.findAll(criterio);
        }
        public Plato findbykey(params object[] key)
        {
            Plato pl = (Plato)ManagerDB<Plato>.findbyKey(key);
            this.Codigo = pl.Codigo;
            this.Detalle = pl.Detalle;
            this.Nombre = pl.Nombre;
            this.IsNew = false;
            return this;
        }
        public bool saveObj()
        {
            return ManagerDB<Plato>.saveObject(this);
        }

        public string TableName
        {
            get { return "plato"; }
        }

        public string KeyTable
        {
            get { return "codigo"; }
        }

        public void initialize(System.Data.DataRow dr)
        {
            this._codigo = Int32.Parse(dr[_columns[0]].ToString());
            this._nombre = dr[_columns[1]].ToString().Trim();
			this._detalle = dr[_columns[2]].ToString().Trim();
            this.IsNew = false;
        }
        public string[] columns
        {
            get { return _columns; }
        }
        private string[] list_values()
        {
            // "codigo","nombre","detalle"
            string[] values = { (this.IsNew?"":_columns[0] + "=")+this._codigo.ToString(),
                                (this.IsNew?"":_columns[1] + "=")+String.Format("'{0}'",this._nombre), //formato cadena ''
                                (this.IsNew?"":_columns[2] + "=")+String.Format("'{0}'",this._detalle)//formato cadena ''
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
