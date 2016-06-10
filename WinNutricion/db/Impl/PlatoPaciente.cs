using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class PlatoPaciente : CommonObj, IAccessDB<PlatoPaciente>, ITable
    {
        private string[] _columns = { "cod_plato","dni_paciente","cantidad","fecha" };
        public List<PlatoPaciente> findAll()
        {
            return this.findAll(null);
        }
        public List<PlatoPaciente> findAll(string criterio)
        {
            return ManagerDB<PlatoPaciente>.findAll(criterio);
        }
        public PlatoPaciente findbykey(params object[] key)
        {
            PlatoPaciente pp = (PlatoPaciente)ManagerDB<PlatoPaciente>.findbyKey(key);
            this.Cantidad = pp.Cantidad;
            this.CodigoPlato = pp.CodigoPlato;
            this.DniPaciente = pp.DniPaciente;
            this.Fecha = pp.Fecha;
            this.IsNew = false;
            return this;
        }
        public bool saveObj()
        {
            return ManagerDB<PlatoPaciente>.saveObject(this);
        }

        public string TableName
        {
            get { return "plato_paciente"; }
        }

        public string KeyTable
        {
            get { return "codigo"; }
        }

        public void initialize(System.Data.DataRow dr)
        {
			//"cod_plato","dni_paciente","cantidad","fecha"
            this._codigoPlato = Int32.Parse(dr[_columns[0]].ToString());
			this._dniPaciente = Int32.Parse(dr[_columns[1]].ToString());
            this._cantidad = float.Parse(dr[_columns[2]].ToString());
            this._fecha = DateTime.Parse(dr[_columns[3]].ToString());
            this.IsNew = false;
        }
        public string[] columns
        {
            get { return _columns; }
        }
        private string[] list_values()
        {
            //"cod_plato","dni_paciente","cantidad","fecha"
            string[] values = { (this.IsNew?"":_columns[0] + "=")+this._codigoPlato.ToString(),
								(this.IsNew?"":_columns[1] + "=")+this._dniPaciente.ToString(),
								(this.IsNew?"":_columns[2] + "=")+this._cantidad.ToString(),
								(this.IsNew?"":_columns[3] + "=")+String.Format("'{0}'",this._fecha.ToString("yyyy-MM-dd")),//formato cadena '
                              };
            return values;
        }

        public string SqlString
        {
            get
            {
                string vvalues = String.Join(",", this.list_values());
                string sqliu = (this.IsNew ? "insert into {0} ({1}) values ({2})" : "update  {0} set {1} where {2}");
                return String.Format(sqliu, this.TableName, (this.IsNew ? String.Join(",", _columns) : vvalues), (this.IsNew ? vvalues : String.Format("codigo_plato = {0} and dni_paciente= {1} and and to_char(fecha, 'YYYY-MM-DD HH24:MI')='{2}'", this.CodigoPlato, this.DniPaciente, this.Fecha)));
            }
        }

        public void setKeyValue(object valueId)
        {
            throw new NotImplementedException();
        }

        public string sqlKeyWhere(params object[] values)
        {
            return String.Format("cod_plato = {0} and dni_paciente = {1}", values[0], values[1]);
        }
    }
}
