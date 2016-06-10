using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class PlatoDieta : CommonObj, IAccessDB<PlatoDieta>, ITable
    {
        private string[] _columns = { "cod_plato","cod_dieta","porcion" };
        public List<PlatoDieta> findAll()
        {
            return this.findAll(null);
        }
        public List<PlatoDieta> findAll(string criterio)
        {
            return ManagerDB<PlatoDieta>.findAll(criterio);
        }
        public PlatoDieta findbykey(params object[] key)
        {
            PlatoDieta pd =  (PlatoDieta)ManagerDB<PlatoDieta>.findbyKey(key);
            this.CodigoDieta = pd.CodigoDieta;
            this.CodigoPlato = pd.CodigoPlato;
            this.Porcion = pd.Porcion;
            this.IsNew = false;
            return this;
        }
        public bool saveObj()
        {
            return ManagerDB<PlatoDieta>.saveObject(this);
        }

        public string TableName
        {
            get { return "plato_dieta"; }
        }

        public string KeyTable
        {
            get { return "codigo"; }
        }

        public void initialize(System.Data.DataRow dr)
        {
			//"cod_plato","cod_dieta","porcion"
            this._codigoPlato = Int32.Parse(dr[_columns[0]].ToString());
			this._codigoDieta = Int32.Parse(dr[_columns[1]].ToString());
            this._porcion = float.Parse(dr[_columns[2]].ToString());
            this.IsNew = false;
        }
        public string[] columns
        {
            get { return _columns; }
        }
        private string[] list_values()
        {
            //"cod_plato","cod_dieta","porcion"
            string[] values = { (this.IsNew?"":_columns[0] + "=")+this._codigoPlato.ToString(),
								(this.IsNew?"":_columns[1] + "=")+this._codigoDieta.ToString(),
								(this.IsNew?"":_columns[2] + "=")+this._porcion.ToString()
                              };
            return values;
        }

        public string SqlString
        {
            get
            {
                string vvalues = String.Join(",", this.list_values());
                string sqliu = (this.IsNew ? "insert into {0} ({1}) values ({2})" : "update  {0} set {1} where {2}");
                return String.Format(sqliu, this.TableName, (this.IsNew ? String.Join(",", _columns) : vvalues), (this.IsNew ? vvalues : String.Format("codigo_plato = {0} and codigo_dieta= {1}", this.CodigoPlato, this.CodigoDieta)));
            }
        }

        public void setKeyValue(object valueId)
        {
            throw new NotImplementedException();
        }

        public string sqlKeyWhere(params object[] values)
        {
            return String.Format("cod_plato = {0} and cod_dieta = {1}", values[0], values[1]);
        }
    }
}
