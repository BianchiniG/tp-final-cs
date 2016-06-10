using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class PlatoIngrediente : CommonObj, IAccessDB<PlatoIngrediente>, ITable
    {
        private string[] _columns = { "cod_plato","cod_ingrediente","cantidad" };
        public List<PlatoIngrediente> findAll()
        {
            return this.findAll(null);
        }
        public List<PlatoIngrediente> findAll(string criterio)
        {
            return ManagerDB<PlatoIngrediente>.findAll(criterio);
        }
        public PlatoIngrediente findbykey(params object[] key)
        {
            PlatoIngrediente pi = (PlatoIngrediente)ManagerDB<PlatoIngrediente>.findbyKey(key);
            this.Cantidad = pi.Cantidad;
            this.CodigoIngrediente = pi.CodigoIngrediente;
            this.CodigoPlato = pi.CodigoPlato;
            this.IsNew = false;
            return this;
        }
        public bool saveObj()
        {
            return ManagerDB<PlatoIngrediente>.saveObject(this);
        }

        public string TableName
        {
            get { return "plato_ingrediente"; }
        }

        public string KeyTable
        {
            get { return "codigo"; }
        }

        public void initialize(System.Data.DataRow dr)
        {
			// "cod_plato","cod_ingrediente","cantidad"
            this._codigoPlato = Int32.Parse(dr[_columns[0]].ToString());
			this._codigoIngrediente = Int32.Parse(dr[_columns[1]].ToString());
            this._cantidad = float.Parse(dr[_columns[2]].ToString());
            this.IsNew = false;
        }
        public string[] columns
        {
            get { return _columns; }
        }
        private string[] list_values()
        {
            // "cod_plato","cod_ingrediente","cantidad"
            string[] values = { (this.IsNew?"":_columns[0] + "=")+this._codigoPlato.ToString(),
								(this.IsNew?"":_columns[1] + "=")+this._codigoIngrediente.ToString(),
								(this.IsNew?"":_columns[2] + "=")+this._cantidad.ToString()
                              };
            return values;
        }

        public string SqlString
        {
            get
            {
                string vvalues = String.Join(",", this.list_values());
                string sqliu = (this.IsNew ? "insert into {0} ({1}) values ({2})" : "update  {0} set {1} where {2}");
                return String.Format(sqliu, this.TableName, (this.IsNew ? String.Join(",", _columns) : vvalues), (this.IsNew ? vvalues : String.Format("codigo_plato = {0} and cod_ingrediente = {1}", this.CodigoPlato, this.CodigoIngrediente)));
            }
        }

        public void setKeyValue(object valueId)
        {
            throw new NotImplementedException();
        }

        public string sqlKeyWhere(params object[] values)
        {
            return String.Format("cod_plato = {0} and cod_ingrediente = {1}", values[0], values[1]);
        }
    }
}
